﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.CommandLine.Collections;

namespace System.CommandLine.Parsing
{
    /// <summary>
    /// An <see cref="AliasedSet{T}"/> containing symbol results.
    /// </summary>
    public class SymbolResultSet : AliasedSet<SymbolResult>
    {
        /// <inheritdoc/>
        protected override IReadOnlyCollection<string> GetAliases(SymbolResult result) =>
            result.Symbol switch
            {
                IIdentifierSymbol named => named.Aliases,
                _ => new[] { result.Symbol.Name }
            };
    }
}