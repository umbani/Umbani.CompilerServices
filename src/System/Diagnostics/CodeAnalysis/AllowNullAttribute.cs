namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that <see langword="null"/> is allowed as an input even if the corresponding type disallows it.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, Inherited = false)]
internal sealed class AllowNullAttribute : Attribute
{
}
