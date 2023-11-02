namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that when a method returns ReturnValue, the parameter may be null even if the corresponding type disallows it.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
internal sealed class MaybeNullWhenAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MaybeNullWhenAttribute"/> class with the specified return value condition.
    /// </summary>
    /// <param name="returnValue"></param>
    public MaybeNullWhenAttribute(bool returnValue)
    {
        ReturnValue = returnValue;
    }

    /// <summary>
    /// Gets the return value condition.
    /// </summary>
    /// <value>
    /// The return value condition. If the method returns this value, the associated parameter may be <see langword="null"/>.
    /// </value>
    public bool ReturnValue { get; }
}
