

using System.ComponentModel;

namespace MudBlazor;

public enum DropPosition
{
    /// <summary>
    /// The before/above position.
    /// </summary>
    [Description("before")]
    Before,
    /// <summary>
    /// The after/below position.
    /// </summary>
    [Description("after")]
    After,

    /// <summary>
    /// The child/descendant position.
    /// </summary>
    [Description("child")]
    Child
}