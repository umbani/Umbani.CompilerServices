namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that when a method returns ReturnValue, the parameter will not be null even if the corresponding type allows it.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
internal sealed class NotNullWhenAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotNullWhenAttribute"/> class with the specified return value condition.
    /// </summary>
    /// <param name="returnValue">The return value condition. If the method returns this value, the associated parameter will not be <see langword="null"/>..</param>
    public NotNullWhenAttribute(bool returnValue)
    {
        ReturnValue = returnValue;
    }

    /// <summary>
    /// Gets the return value condition.
    /// </summary>
    /// <value>
    /// The return value condition. If the method returns this value, the associated parameter will not be <see langword="null"/>.
    /// </value>
    public bool ReturnValue { get; }
}
