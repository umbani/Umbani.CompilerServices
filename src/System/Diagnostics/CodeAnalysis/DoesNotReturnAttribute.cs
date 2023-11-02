namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that a method that will never return under any circumstance.
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
internal sealed class DoesNotReturnAttribute : Attribute
{
}
