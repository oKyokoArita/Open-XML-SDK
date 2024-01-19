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
    /// Defines the PresentationPart
    /// </summary>
    public partial class PresentationPart : OpenXmlPart,
        ISupportedRelationship<CustomXmlPart>,
        ISupportedRelationship<FontPart>
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
        private DocumentFormat.OpenXml.Presentation.Presentation? _rootElement;

        /// <summary>
        /// Creates an instance of the PresentationPart OpenXmlType
        /// </summary>
        internal PresentationPart()
        {
        }

        /// <summary>
        /// Gets the authorsPart of the PresentationPart
        /// </summary>
        public PowerPointAuthorsPart? authorsPart => GetSubPartOfType<PowerPointAuthorsPart>();

        /// <summary>
        /// Gets the CommentAuthorsPart of the PresentationPart
        /// </summary>
        public CommentAuthorsPart? CommentAuthorsPart => GetSubPartOfType<CommentAuthorsPart>();

        /// <summary>
        /// Gets the commentParts of the PresentationPart
        /// </summary>
        public IEnumerable<PowerPointCommentPart> commentParts => GetPartsOfType<PowerPointCommentPart>();

        /// <summary>
        /// Gets the CustomXmlParts of the PresentationPart
        /// </summary>
        public IEnumerable<CustomXmlPart> CustomXmlParts => GetPartsOfType<CustomXmlPart>();

        /// <summary>
        /// Gets the FontParts of the PresentationPart
        /// </summary>
        public IEnumerable<FontPart> FontParts => GetPartsOfType<FontPart>();

        /// <summary>
        /// Gets the HandoutMasterPart of the PresentationPart
        /// </summary>
        public HandoutMasterPart? HandoutMasterPart => GetSubPartOfType<HandoutMasterPart>();

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Presentation.Presentation;
            }
        }

        /// <summary>
        /// Gets the LegacyDiagramTextInfoPart of the PresentationPart
        /// </summary>
        public LegacyDiagramTextInfoPart? LegacyDiagramTextInfoPart => GetSubPartOfType<LegacyDiagramTextInfoPart>();

        /// <summary>
        /// Gets the NotesMasterPart of the PresentationPart
        /// </summary>
        public NotesMasterPart? NotesMasterPart => GetSubPartOfType<NotesMasterPart>();

        internal override OpenXmlPartRootElement? PartRootElement => Presentation;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Presentation.Presentation Presentation
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Presentation.Presentation>();
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
        /// Gets the PresentationPropertiesPart of the PresentationPart
        /// </summary>
        public PresentationPropertiesPart? PresentationPropertiesPart => GetSubPartOfType<PresentationPropertiesPart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SlideMasterParts of the PresentationPart
        /// </summary>
        public IEnumerable<SlideMasterPart> SlideMasterParts => GetPartsOfType<SlideMasterPart>();

        /// <summary>
        /// Gets the SlideParts of the PresentationPart
        /// </summary>
        public IEnumerable<SlidePart> SlideParts => GetPartsOfType<SlidePart>();

        /// <summary>
        /// Gets the TableStylesPart of the PresentationPart
        /// </summary>
        public TableStylesPart? TableStylesPart => GetSubPartOfType<TableStylesPart>();

        /// <summary>
        /// Gets the ThemePart of the PresentationPart
        /// </summary>
        public ThemePart? ThemePart => GetSubPartOfType<ThemePart>();

        /// <summary>
        /// Gets the UserDefinedTagsPart of the PresentationPart
        /// </summary>
        public UserDefinedTagsPart? UserDefinedTagsPart => GetSubPartOfType<UserDefinedTagsPart>();

        /// <summary>
        /// Gets the VbaProjectPart of the PresentationPart
        /// </summary>
        public VbaProjectPart? VbaProjectPart => GetSubPartOfType<VbaProjectPart>();

        /// <summary>
        /// Gets the ViewPropertiesPart of the PresentationPart
        /// </summary>
        public ViewPropertiesPart? ViewPropertiesPart => GetSubPartOfType<ViewPropertiesPart>();
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "presentation";
            string ITargetFeature.Path => "ppt";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps", "application/vnd.openxmlformats-officedocument.presentationml.presProps+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles", "application/vnd.openxmlformats-officedocument.presentationml.tableStyles+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", "application/vnd.openxmlformats-officedocument.theme+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps", "application/vnd.openxmlformats-officedocument.presentationml.viewProps+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster", "application/vnd.openxmlformats-officedocument.presentationml.notesMaster+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", "application/vnd.openxmlformats-officedocument.presentationml.slide+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster", "application/vnd.openxmlformats-officedocument.presentationml.slideMaster+xml", true, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", "application/vnd.openxmlformats-officedocument.presentationml.tags+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors", "application/vnd.openxmlformats-officedocument.presentationml.commentAuthors+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster", "application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo", "application/vnd.ms-office.legacyDocTextInfo", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2006/relationships/vbaProject", "application/vnd.ms-office.vbaProject", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2018/10/relationships/comments", "application/vnd.ms-powerpoint.comments+xml", false, true, FileFormatVersions.Office2021 },
                { "http://schemas.microsoft.com/office/2018/10/relationships/authors", "application/vnd.ms-powerpoint.authors+xml", false, false, FileFormatVersions.Office2021 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
