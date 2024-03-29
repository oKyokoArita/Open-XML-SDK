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

namespace DocumentFormat.OpenXml.Office2019.Drawing.Ink
{
    /// <summary>
    /// Defines the ExtendedBrushPropertyName enumeration.
    /// </summary>
    public readonly record struct ExtendedBrushPropertyName : IEnumValue, IEnumValueFactory<ExtendedBrushPropertyName>
    {
        private readonly string? _value;
        /// <summary>
        /// Creates a new ExtendedBrushPropertyName enum instance
        /// </summary>
        public ExtendedBrushPropertyName(string value) => _value = value;
        ExtendedBrushPropertyName IEnumValueFactory<ExtendedBrushPropertyName>.Create(string name) => new(name);
        bool IEnumValue.IsValid => InternalValue switch
        {
            "inkEffects" => true,
            "anchorX" => true,
            "anchorY" => true,
            "scaleFactor" => true,
            _ => false
        };
        string IEnumValue.Value => InternalValue;
        private string InternalValue => _value ?? "inkEffects";
        FileFormatVersions IEnumValue.Version => FileFormatVersions.Office2019;
        /// <summary>
        /// inkEffects.
        /// <para>When the item is serialized out as xml, its value is "inkEffects".</para>
        /// </summary>
        public static ExtendedBrushPropertyName InkEffects => new("inkEffects");
        /// <summary>
        /// anchorX.
        /// <para>When the item is serialized out as xml, its value is "anchorX".</para>
        /// </summary>
        public static ExtendedBrushPropertyName AnchorX => new("anchorX");
        /// <summary>
        /// anchorY.
        /// <para>When the item is serialized out as xml, its value is "anchorY".</para>
        /// </summary>
        public static ExtendedBrushPropertyName AnchorY => new("anchorY");
        /// <summary>
        /// scaleFactor.
        /// <para>When the item is serialized out as xml, its value is "scaleFactor".</para>
        /// </summary>
        public static ExtendedBrushPropertyName ScaleFactor => new("scaleFactor");
    
    }

    /// <summary>
    /// Defines the InkEffectsType enumeration.
    /// </summary>
    public readonly record struct InkEffectsType : IEnumValue, IEnumValueFactory<InkEffectsType>
    {
        private readonly string? _value;
        /// <summary>
        /// Creates a new InkEffectsType enum instance
        /// </summary>
        public InkEffectsType(string value) => _value = value;
        InkEffectsType IEnumValueFactory<InkEffectsType>.Create(string name) => new(name);
        bool IEnumValue.IsValid => InternalValue switch
        {
            "none" => true,
            "pencil" => true,
            "rainbow" => true,
            "galaxy" => true,
            "gold" => true,
            "silver" => true,
            "lava" => true,
            "ocean" => true,
            "rosegold" => true,
            "bronze" => true,
            _ => false
        };
        string IEnumValue.Value => InternalValue;
        private string InternalValue => _value ?? "none";
        FileFormatVersions IEnumValue.Version => FileFormatVersions.Office2019;
        /// <summary>
        /// none.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        public static InkEffectsType None => new("none");
        /// <summary>
        /// pencil.
        /// <para>When the item is serialized out as xml, its value is "pencil".</para>
        /// </summary>
        public static InkEffectsType Pencil => new("pencil");
        /// <summary>
        /// rainbow.
        /// <para>When the item is serialized out as xml, its value is "rainbow".</para>
        /// </summary>
        public static InkEffectsType Rainbow => new("rainbow");
        /// <summary>
        /// galaxy.
        /// <para>When the item is serialized out as xml, its value is "galaxy".</para>
        /// </summary>
        public static InkEffectsType Galaxy => new("galaxy");
        /// <summary>
        /// gold.
        /// <para>When the item is serialized out as xml, its value is "gold".</para>
        /// </summary>
        public static InkEffectsType Gold => new("gold");
        /// <summary>
        /// silver.
        /// <para>When the item is serialized out as xml, its value is "silver".</para>
        /// </summary>
        public static InkEffectsType Silver => new("silver");
        /// <summary>
        /// lava.
        /// <para>When the item is serialized out as xml, its value is "lava".</para>
        /// </summary>
        public static InkEffectsType Lava => new("lava");
        /// <summary>
        /// ocean.
        /// <para>When the item is serialized out as xml, its value is "ocean".</para>
        /// </summary>
        public static InkEffectsType Ocean => new("ocean");
        /// <summary>
        /// rosegold.
        /// <para>When the item is serialized out as xml, its value is "rosegold".</para>
        /// </summary>
        public static InkEffectsType Rosegold => new("rosegold");
        /// <summary>
        /// bronze.
        /// <para>When the item is serialized out as xml, its value is "bronze".</para>
        /// </summary>
        public static InkEffectsType Bronze => new("bronze");
    
    }
}