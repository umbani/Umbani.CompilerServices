namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that the output will be non-null if the named parameter is non-null.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
internal sealed class NotNullIfNotNullAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotNullIfNotNullAttribute"/> class with the specified parameter name.
    /// </summary>
    /// <param name="parameterName">The associated parameter name. The output will be non-null if the argument to the parameter specified is non-null.</param>
    public NotNullIfNotNullAttribute(string parameterName)
    {
        ParameterName = parameterName;
    }

    /// <summary>
    /// Gets the associated parameter name.
    /// </summary>
    /// <value>
    /// The associated parameter name. The output will be non-null if the argument to the parameter specified is non-null.
    /// </value>
    public string ParameterName { get; }
}
