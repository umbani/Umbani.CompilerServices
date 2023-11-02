namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that <see langword="null"/> is disallowed as an input even if the corresponding type allows it.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, Inherited = false)]
internal sealed class DisallowNullAttribute : Attribute
{
}
