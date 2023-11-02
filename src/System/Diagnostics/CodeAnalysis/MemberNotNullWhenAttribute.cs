#nullable enable

namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that the method or property will ensure that the listed field and property members have non-null values when returning with
/// the specified return value condition.
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
internal sealed class MemberNotNullWhenAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MemberNotNullWhenAttribute"/> class with the specified return value condition and
    /// a field or property member.
    /// </summary>
    /// <param name="returnValue">The return value condition. If the method returns this value, the associated parameter will not be <see langword="null"/>.</param>
    /// <param name="member">The field or property member that is promised to be non-null.</param>
#pragma warning disable CA1019 // Define accessors for attribute arguments
    public MemberNotNullWhenAttribute(bool returnValue, string member)
#pragma warning restore CA1019 // Define accessors for attribute arguments
    {
        ReturnValue = returnValue;
        Members = new[] { member };
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MemberNotNullWhenAttribute"/> class with the specified return value condition and
    /// list of field and property members.
    /// </summary>
    /// <param name="returnValue">The return value condition. If the method returns this value, the associated parameter will not be <see langword="null"/>.</param>
    /// <param name="members">The list of field and property members that are promised to be non-null.</param>
    public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
    {
        ReturnValue = returnValue;
        Members = members;
    }

    /// <summary>
    /// Gets the field or property member names.
    /// </summary>
    /// <value>
    /// The field or property member names.
    /// </value>
    public string[] Members { get; }

    /// <summary>
    /// Gets the return value condition.
    /// </summary>
    /// <value>
    /// The return value condition.
    /// </value>
    public bool ReturnValue { get; }
}
