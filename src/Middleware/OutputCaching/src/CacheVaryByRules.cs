// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Microsoft.Extensions.Primitives;

namespace Microsoft.AspNetCore.OutputCaching;

/// <summary>
/// Represents vary-by rules.
/// </summary>
public sealed class CacheVaryByRules
{
    private Dictionary<string, string>? _varyByValues;

    internal bool HasVaryByValues => _varyByValues != null && _varyByValues.Any();

    /// <summary>
    /// Gets a dictionary of key-pair values to vary by.
    /// </summary>
    public Dictionary<string, string> VaryByValues => _varyByValues ??= new ();

    /// <summary>
    /// Gets or sets the list of route value names to vary by.
    /// </summary>
    public StringValues RouteValueNames { get; set; }

    /// <summary>
    /// Gets or sets the list of header names to vary by.
    /// </summary>
    public StringValues HeaderNames { get; set; }

    /// <summary>
    /// Gets or sets the list of query string keys to vary by.
    /// </summary>
    public StringValues QueryKeys { get; set; }

    /// <summary>
    /// Gets or sets a prefix to vary by.
    /// </summary>
    public string? VaryByKeyPrefix { get; set; }
}
