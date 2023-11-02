namespace System.Runtime.CompilerServices;

/// <summary>
/// Specifies that a type has required members or that a member is required.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple=false, Inherited=false)]
internal sealed class RequiredMemberAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RequiredMemberAttribute"/> class.
    /// </summary>
    public RequiredMemberAttribute()
    {
    }
}
