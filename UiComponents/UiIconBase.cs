namespace UiComponents;

using Microsoft.AspNetCore.Components;
using UiComponents.Theming;

public abstract class UiIconBase : ComponentBase
{
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> UnmatchedAttributes { get; set; } = new();

    [Parameter] public RenderFragment? ChildContent { get; set; }

    [Inject] protected ThemeProvider Theme { get; set; } = null!;

    protected Dictionary<string, object> Attributes => UnmatchedAttributes.Where(a => a.Key != "class").ToDictionary();
    protected string? ClassAttribute => UnmatchedAttributes.FirstOrDefault(a => a.Key == "class").Value?.ToString();
}

/// <summary>
/// The type/size of the icon.
/// </summary>
public enum IconType
{
    Solid,
    Outline
}