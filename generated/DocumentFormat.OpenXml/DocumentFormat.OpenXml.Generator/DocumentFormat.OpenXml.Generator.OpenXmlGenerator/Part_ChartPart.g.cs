// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ChartPart
    /// </summary>
    public partial class ChartPart : OpenXmlPart,
        IFixedContentTypePart,
        ISupportedRelationship<EmbeddedPackagePart>,
        ISupportedRelationship<ImagePart>
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.drawingml.chart+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart";
        private DocumentFormat.OpenXml.Drawing.Charts.ChartSpace? _rootElement;

        /// <summary>
        /// Creates an instance of the ChartPart OpenXmlType
        /// </summary>
        internal ChartPart()
        {
        }

        /// <summary>
        /// Gets the ChartColorStyleParts of the ChartPart
        /// </summary>
        public IEnumerable<ChartColorStylePart> ChartColorStyleParts => GetPartsOfType<ChartColorStylePart>();

        /// <summary>
        /// Gets the ChartDrawingPart of the ChartPart
        /// </summary>
        public ChartDrawingPart? ChartDrawingPart => GetSubPartOfType<ChartDrawingPart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartSpace ChartSpace
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Drawing.Charts.ChartSpace>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        /// <summary>
        /// Gets the ChartStyleParts of the ChartPart
        /// </summary>
        public IEnumerable<ChartStylePart> ChartStyleParts => GetPartsOfType<ChartStylePart>();

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the EmbeddedPackagePart of the ChartPart
        /// </summary>
        public EmbeddedPackagePart? EmbeddedPackagePart => GetSubPartOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ImageParts of the ChartPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Drawing.Charts.ChartSpace;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => ChartSpace;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the ThemeOverridePart of the ChartPart
        /// </summary>
        public ThemeOverridePart? ThemeOverridePart => GetSubPartOfType<ThemeOverridePart>();
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "chart";
            string ITargetFeature.Path => "charts";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes", "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", null, false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride", "application/vnd.openxmlformats-officedocument.themeOverride+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2011/relationships/chartStyle", "application/vnd.ms-office.chartstyle+xml", false, true, FileFormatVersions.Office2013 },
                { "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle", "application/vnd.ms-office.chartcolorstyle+xml", false, true, FileFormatVersions.Office2013 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
