// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Packaging;

partial class PresentationDocument 
{
    partial class PresentationDocumentFeatures : IPartFactoryFeature 
    {
        OpenXmlPart? IPartFactoryFeature.Create(string relationship) => relationship switch
        {
            ChartColorStylePart.RelationshipTypeConstant => new ChartColorStylePart(),
            ChartDrawingPart.RelationshipTypeConstant => new ChartDrawingPart(),
            ChartPart.RelationshipTypeConstant => new ChartPart(),
            ChartStylePart.RelationshipTypeConstant => new ChartStylePart(),
            CommentAuthorsPart.RelationshipTypeConstant => new CommentAuthorsPart(),
            ControlPropertiesPart.RelationshipTypeConstant => new ControlPropertiesPart(),
            CoreFilePropertiesPart.RelationshipTypeConstant => new CoreFilePropertiesPart(),
            CustomFilePropertiesPart.RelationshipTypeConstant => new CustomFilePropertiesPart(),
            CustomPropertyPart.RelationshipTypeConstant => new CustomPropertyPart(),
            CustomXmlPart.RelationshipTypeConstant => new CustomXmlPart(),
            CustomXmlPropertiesPart.RelationshipTypeConstant => new CustomXmlPropertiesPart(),
            DiagramColorsPart.RelationshipTypeConstant => new DiagramColorsPart(),
            DiagramDataPart.RelationshipTypeConstant => new DiagramDataPart(),
            DiagramLayoutDefinitionPart.RelationshipTypeConstant => new DiagramLayoutDefinitionPart(),
            DiagramPersistLayoutPart.RelationshipTypeConstant => new DiagramPersistLayoutPart(),
            DiagramStylePart.RelationshipTypeConstant => new DiagramStylePart(),
            DigitalSignatureOriginPart.RelationshipTypeConstant => new DigitalSignatureOriginPart(),
            DrawingsPart.RelationshipTypeConstant => new DrawingsPart(),
            EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant => new EmbeddedControlPersistenceBinaryDataPart(),
            EmbeddedControlPersistencePart.RelationshipTypeConstant => new EmbeddedControlPersistencePart(),
            EmbeddedObjectPart.RelationshipTypeConstant => new EmbeddedObjectPart(),
            EmbeddedPackagePart.RelationshipTypeConstant => new EmbeddedPackagePart(),
            ExtendedChartPart.RelationshipTypeConstant => new ExtendedChartPart(),
            ExtendedFilePropertiesPart.RelationshipTypeConstant => new ExtendedFilePropertiesPart(),
            FontPart.RelationshipTypeConstant => new FontPart(),
            HandoutMasterPart.RelationshipTypeConstant => new HandoutMasterPart(),
            ImagePart.RelationshipTypeConstant => new ImagePart(),
            LabelInfoPart.RelationshipTypeConstant => new LabelInfoPart(),
            LegacyDiagramTextInfoPart.RelationshipTypeConstant => new LegacyDiagramTextInfoPart(),
            LegacyDiagramTextPart.RelationshipTypeConstant => new LegacyDiagramTextPart(),
            Model3DReferenceRelationshipPart.RelationshipTypeConstant => new Model3DReferenceRelationshipPart(),
            NamedSheetViewsPart.RelationshipTypeConstant => new NamedSheetViewsPart(),
            NotesMasterPart.RelationshipTypeConstant => new NotesMasterPart(),
            NotesSlidePart.RelationshipTypeConstant => new NotesSlidePart(),
            PivotTableCacheDefinitionPart.RelationshipTypeConstant => new PivotTableCacheDefinitionPart(),
            PivotTableCacheRecordsPart.RelationshipTypeConstant => new PivotTableCacheRecordsPart(),
            PivotTablePart.RelationshipTypeConstant => new PivotTablePart(),
            PowerPointAuthorsPart.RelationshipTypeConstant => new PowerPointAuthorsPart(),
            PowerPointCommentPart.RelationshipTypeConstant => new PowerPointCommentPart(),
            PresentationPart.RelationshipTypeConstant => new PresentationPart(),
            PresentationPropertiesPart.RelationshipTypeConstant => new PresentationPropertiesPart(),
            QueryTablePart.RelationshipTypeConstant => new QueryTablePart(),
            QuickAccessToolbarCustomizationsPart.RelationshipTypeConstant => new QuickAccessToolbarCustomizationsPart(),
            RibbonAndBackstageCustomizationsPart.RelationshipTypeConstant => new RibbonAndBackstageCustomizationsPart(),
            RibbonExtensibilityPart.RelationshipTypeConstant => new RibbonExtensibilityPart(),
            SingleCellTablePart.RelationshipTypeConstant => new SingleCellTablePart(),
            SlicersPart.RelationshipTypeConstant => new SlicersPart(),
            SlideCommentsPart.RelationshipTypeConstant => new SlideCommentsPart(),
            SlideLayoutPart.RelationshipTypeConstant => new SlideLayoutPart(),
            SlideMasterPart.RelationshipTypeConstant => new SlideMasterPart(),
            SlidePart.RelationshipTypeConstant => new SlidePart(),
            SlideSyncDataPart.RelationshipTypeConstant => new SlideSyncDataPart(),
            TableDefinitionPart.RelationshipTypeConstant => new TableDefinitionPart(),
            TableStylesPart.RelationshipTypeConstant => new TableStylesPart(),
            ThemeOverridePart.RelationshipTypeConstant => new ThemeOverridePart(),
            ThemePart.RelationshipTypeConstant => new ThemePart(),
            ThumbnailPart.RelationshipTypeConstant => new ThumbnailPart(),
            TimeLinePart.RelationshipTypeConstant => new TimeLinePart(),
            UserDefinedTagsPart.RelationshipTypeConstant => new UserDefinedTagsPart(),
            VbaDataPart.RelationshipTypeConstant => new VbaDataPart(),
            VbaProjectPart.RelationshipTypeConstant => new VbaProjectPart(),
            ViewPropertiesPart.RelationshipTypeConstant => new ViewPropertiesPart(),
            VmlDrawingPart.RelationshipTypeConstant => new VmlDrawingPart(),
            WebExTaskpanesPart.RelationshipTypeConstant => new WebExTaskpanesPart(),
            WebExtensionPart.RelationshipTypeConstant => new WebExtensionPart(),
            WorksheetPart.RelationshipTypeConstant => new WorksheetPart(),
            WorksheetSortMapPart.RelationshipTypeConstant => new WorksheetSortMapPart(),
            WorksheetThreadedCommentsPart.RelationshipTypeConstant => new WorksheetThreadedCommentsPart(),
            XmlSignaturePart.RelationshipTypeConstant => new XmlSignaturePart(),
            _ => default,
        };
    }
}
