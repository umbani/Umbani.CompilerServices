namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that an output is not <see langword="null"/> even if the corresponding type allows it. Specifies that an input argument was
/// not <see langword="null"/> when the call returns.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, Inherited = false)]
internal sealed class NotNullAttribute : Attribute
{
}
