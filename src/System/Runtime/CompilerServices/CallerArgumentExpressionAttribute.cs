#nullable enable

namespace System.Runtime.CompilerServices;

/// <summary>
/// Indicates that a parameter captures the expression passed for another parameter as a string.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
internal sealed class CallerArgumentExpressionAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CallerArgumentExpressionAttribute"/> class with the specified parameter name.
    /// </summary>
    /// <param name="parameterName">The name of the parameter whose expression should be captured as a string.</param>439885
    public CallerArgumentExpressionAttribute(string parameterName)
    {
        ParameterName = parameterName;
    }

    /// <summary>
    /// Gets the name of the parameter whose expression should be captured as a string.
    /// </summary>
    /// <value>
    /// The name of the parameter whose expression should be captured.
    /// </value>
    public string ParameterName { get; }
}
