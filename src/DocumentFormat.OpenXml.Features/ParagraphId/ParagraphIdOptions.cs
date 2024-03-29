// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Options to declare how paragraph ids should be generated.
    /// </summary>
    public class ParagraphIdOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether or not paragraph ids should be auto-generated on elements.
        /// </summary>
        public bool AutoGenerateIds { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether or not uniqueness should be guaranteed on elements added to the document. This will change a node's para id if it has already been registered.
        /// </summary>
        public bool EnsureUniquenessOnExistingNodes { get; set; } = true;
    }
}
