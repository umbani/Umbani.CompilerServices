#nullable enable

namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Indicates that the specified method parameter expects a constant.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
internal sealed class ConstantExpectedAttribute : Attribute
{
    /// <summary>
    /// Gets or sets the maximum bound of the expected constant, inclusive.
    /// </summary>
    /// <value>
    /// The maximum bound of the expected constant, inclusive.
    /// </value>
    public object? Max { get; set; }

    /// <summary>
    /// Gets or sets the minimum bound of the expected constant, inclusive.
    /// </summary>
    /// <value>
    /// The minimum bound of the expected constant, inclusive.
    /// </value>
    public object? Min { get; set; }
}
