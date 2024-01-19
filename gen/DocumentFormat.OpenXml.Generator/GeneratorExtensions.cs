// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using DocumentFormat.OpenXml.Generator.Schematron;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;

using IncrementalOpenXmlTextValuesProvider = Microsoft.CodeAnalysis.IncrementalValuesProvider<(Microsoft.CodeAnalysis.AdditionalText Text, string Type)>;

namespace DocumentFormat.OpenXml.Generator;

public static class GeneratorExtensions
{
    // NOTE: These must align with the metadata defined in SourceGenerator.targets
    private const string AdditionalFileNamespace = "Namespace";
    private const string AdditionalFilePart = "Part";
    private const string AdditionalFileSchema = "Schema";
    private const string AdditionalFileSchematron = "Schematron";
    private const string AdditionalFileTypedSchema = "TypedSchema";
    private const string AdditionalFileTypedNamespace = "TypedNamespace";

    private const string OptionsPrefix = "build_property.DocumentFormat_OpenXml_Generator_";
    private const string OptionsGenerateNamespace = $"{OptionsPrefix}NamespaceLookup";
    private const string OptionsGeneratePart = $"{OptionsPrefix}Parts";
    private const string OptionsGenerateSchemas = $"{OptionsPrefix}Schemas";
    private const string OptionsGenerateFactories = $"{OptionsPrefix}Factories";
    private const string OptionsGenerateLinq = $"{OptionsPrefix}Linq";

    public static IncrementalValueProvider<T?> When<T>(this IncrementalValueProvider<T> services, IncrementalValueProvider<OpenXmlGeneratorOptions> options, Func<OpenXmlGeneratorOptions, bool> predicate)
        where T : class
        => services.Combine(options)
            .Select((t, _) => predicate(t.Right) ? t.Left : null);

    public static IncrementalValueProvider<OpenXmlGeneratorOptions> GetOpenXmlOptions(this IncrementalGeneratorInitializationContext context)
        => context.AnalyzerConfigOptionsProvider.Select((options, token) =>
        {
            return new OpenXmlGeneratorOptions
            {
                GenerateNamespaces = IsEnabled(options, OptionsGenerateNamespace),
                GenerateParts = IsEnabled(options, OptionsGeneratePart),
                GenerateSchema = IsEnabled(options, OptionsGenerateSchemas),
                GenerateFactories = IsEnabled(options, OptionsGenerateFactories),
                GenerateLinq = IsEnabled(options, OptionsGenerateLinq),
            };

            static bool IsEnabled(AnalyzerConfigOptionsProvider options, string name)
                => options.GlobalOptions.TryGetValue(name, out var generatorSwitch) && bool.TryParse(generatorSwitch, out var result) && result;
        });

    public static IncrementalValueProvider<ImmutableArray<NamespaceInfo>> GetKnownNamespaces(this IncrementalOpenXmlTextValuesProvider types)
        => types
            .IsOpenXmlType(AdditionalFileNamespace)
            .Deserialize<NamespaceInfo[]>()
            .SelectMany((n, _) => n ?? Enumerable.Empty<NamespaceInfo>())
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<Part>> GetParts(this IncrementalOpenXmlTextValuesProvider types)
        => types
            .IsOpenXmlType(AdditionalFilePart)
            .Deserialize<Part>()
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<SchemaNamespace>> GetNamespaceTypes(this IncrementalOpenXmlTextValuesProvider texts)
        => texts
            .IsOpenXmlType(AdditionalFileSchema)
            .Deserialize<SchemaNamespace>()
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<SchematronEntry>> GetSchematrons(this IncrementalOpenXmlTextValuesProvider texts)
        => texts
            .IsOpenXmlType(AdditionalFileSchematron)
            .Deserialize<SchematronEntry[]>()
            .SelectMany((s, _) => s ?? Enumerable.Empty<SchematronEntry>())
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<StronglyTypedElement>> GetStronglyTypedSchemas(this IncrementalOpenXmlTextValuesProvider texts)
        => texts
            .IsOpenXmlType(AdditionalFileTypedSchema)
            .Deserialize<StronglyTypedElement[]>()
            .SelectMany((s, _) => s ?? Enumerable.Empty<StronglyTypedElement>())
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<StronglyTypedNamespace>> GetStronglyTypedNamespace(this IncrementalOpenXmlTextValuesProvider texts)
        => texts
            .IsOpenXmlType(AdditionalFileTypedNamespace)
            .Deserialize<StronglyTypedNamespace[]>()
            .SelectMany((s, _) => s ?? Enumerable.Empty<StronglyTypedNamespace>())
            .Collect();

    public static IncrementalValueProvider<OpenXmlGeneratorDataSource> GetOpenXmlGeneratorContext(this IncrementalOpenXmlTextValuesProvider openXmlFiles)
    {
        var namespaces = openXmlFiles.GetKnownNamespaces();
        var namespaceTypes = openXmlFiles.GetNamespaceTypes();
        var parts = openXmlFiles.GetParts();
        var schematrons = openXmlFiles.GetSchematrons();
        var stronglyTypedSchema = openXmlFiles.GetStronglyTypedSchemas();
        var stronglyTypedNamespace = openXmlFiles.GetStronglyTypedNamespace();

        return namespaces.Combine(namespaceTypes).Combine(parts).Combine(schematrons).Combine(stronglyTypedSchema).Combine(stronglyTypedNamespace)
            .Select((arg, token) => new OpenXmlGeneratorDataSource
            {
                KnownNamespaces = arg.Left.Left.Left.Left.Left,
                Namespaces = arg.Left.Left.Left.Left.Right,
                Parts = arg.Left.Left.Left.Right.Where(t => !t.IsPackage).ToImmutableArray(),
                Packages = arg.Left.Left.Left.Right.Where(t => t.IsPackage).ToImmutableArray(),
                Schematrons = arg.Left.Left.Right,
                TypedClasses = arg.Left.Right,
                TypedNamespaces = arg.Right,
            });
    }

    public static IncrementalValueProvider<OpenXmlGeneratorServices> GetOpenXmlServices(this IncrementalValueProvider<OpenXmlGeneratorDataSource> context)
        => context.Select((context, _) => new OpenXmlGeneratorServices(context));

    public static IncrementalOpenXmlTextValuesProvider GetOpenXmlDataFiles(this IncrementalGeneratorInitializationContext context)
        => context.AdditionalTextsProvider
                .Combine(context.AnalyzerConfigOptionsProvider)
                .Select((args, token) =>
                {
                    if (args.Right.GetOptions(args.Left).TryGetValue("build_metadata.AdditionalFiles.OpenXml", out var result))
                    {
                        return (args.Left, result);
                    }

                    return default;
                })
                .Where(args => args != default);

    // Some parts serve in multiple places and end up getting pulled in here unintentionally
    private static readonly Dictionary<string, HashSet<string>> _invalidParts = new Dictionary<string, HashSet<string>>()
    {
        { "PresentationDocument", new() { "WorksheetCommentsPart", "SpreadsheetPrinterSettingsPart" } },
        { "SpreadsheetDocument", new() { "SlideCommentsPart" } },
        { "WordprocessingDocument", new() { "WorksheetCommentsPart", "SlideCommentsPart", "SpreadsheetPrinterSettingsPart" } },
    };

    public static ImmutableArray<Part> GetParts(this OpenXmlGeneratorServices o, string package)
    {
        var doc = o.DataSource.Packages.FirstOrDefault(p => p.Name == package);

        if (doc is null)
        {
            return ImmutableArray.Create<Part>();
        }

        var result = ImmutableArray.CreateBuilder<Part>();
        var dict = o.DataSource.Parts.ToDictionary(p => p.Name);

        var invalid = _invalidParts[doc.Name];
        var seen = new HashSet<string>();
        var queue = new Queue<Part>();
        queue.Enqueue(doc);

        while (queue.Count > 0)
        {
            var part = queue.Dequeue();

            foreach (var child in part.Children)
            {
                if (!child.IsDataPartReference && !invalid.Contains(child.Name) && seen.Add(child.Name) && dict.TryGetValue(child.Name, out var childPart))
                {
                    queue.Enqueue(childPart);
                    result.Add(childPart);
                }
            }
        }

        return result.ToImmutable();
    }

    public static IncrementalValueProvider<ImmutableArray<PackageInformation>> GetPackageFactories(this IncrementalValueProvider<OpenXmlGeneratorServices?> services)
        => services.Select((o, token) =>
        {
            if (o is null)
            {
                return ImmutableArray.Create<PackageInformation>();
            }

            var result = ImmutableArray.CreateBuilder<PackageInformation>();

            var dict = o.DataSource.Parts.ToDictionary(p => p.Name);

            foreach (var doc in o.DataSource.Packages)
            {
                var partResults = o.GetParts(doc.Name);
                result.Add(new(doc.Name, partResults));
            }

            return result.ToImmutable();
        });

    private static IncrementalValuesProvider<AdditionalText> IsOpenXmlType(this IncrementalOpenXmlTextValuesProvider types, string type)
        => types.Where(t => string.Equals(t.Type, type, StringComparison.Ordinal)).Select((t, _) => t.Text);

    private static IncrementalValuesProvider<T> Deserialize<T>(this IncrementalValuesProvider<AdditionalText> texts)
        => texts.Select((t, token) => OpenXmlGeneratorDataSource.Deserialize<T>(t.GetText(token)?.ToString())).Where(t => t is not null)!;
}
