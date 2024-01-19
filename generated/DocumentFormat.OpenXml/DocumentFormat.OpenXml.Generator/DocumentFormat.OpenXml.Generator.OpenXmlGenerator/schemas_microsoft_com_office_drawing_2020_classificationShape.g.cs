// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification
{
    /// <summary>
    /// <para>Defines the ClassificationOutcome Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is aclsh:classification.</para>
    /// </summary>
    public partial class ClassificationOutcome : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ClassificationOutcome class.
        /// </summary>
        public ClassificationOutcome() : base()
        {
        }

        /// <summary>
        /// <para>classificationOutcomeType, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: classificationOutcomeType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType>? ClassificationOutcomeType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("aclsh:classification");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<ClassificationOutcome>()
                .AddAttribute("classificationOutcomeType", a => a.ClassificationOutcomeType, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClassificationOutcome>(deep);
    }

    /// <summary>
    /// Defines the ClassificationOutcomeType enumeration.
    /// </summary>
    public readonly record struct ClassificationOutcomeType : IEnumValue, IEnumValueFactory<ClassificationOutcomeType>
    {
        private readonly string? _value;
        /// <summary>
        /// Creates a new ClassificationOutcomeType enum instance
        /// </summary>
        public ClassificationOutcomeType(string value) => _value = value;
        ClassificationOutcomeType IEnumValueFactory<ClassificationOutcomeType>.Create(string name) => new(name);
        bool IEnumValue.IsValid => InternalValue switch
        {
            "none" => true,
            "hdr" => true,
            "ftr" => true,
            "watermark" => true,
            _ => false
        };
        string IEnumValue.Value => InternalValue;
        private string InternalValue => _value ?? "none";
        FileFormatVersions IEnumValue.Version => FileFormatVersions.Office2021;
        /// <summary>
        /// none.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        public static ClassificationOutcomeType None => new("none");
        /// <summary>
        /// hdr.
        /// <para>When the item is serialized out as xml, its value is "hdr".</para>
        /// </summary>
        public static ClassificationOutcomeType Hdr => new("hdr");
        /// <summary>
        /// ftr.
        /// <para>When the item is serialized out as xml, its value is "ftr".</para>
        /// </summary>
        public static ClassificationOutcomeType Ftr => new("ftr");
        /// <summary>
        /// watermark.
        /// <para>When the item is serialized out as xml, its value is "watermark".</para>
        /// </summary>
        public static ClassificationOutcomeType Watermark => new("watermark");
    
    }
}