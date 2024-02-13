using Microsoft.AspNetCore.Components;
using UiComponents.Theming;

namespace UiComponents;

public class UiComponentBase : ComponentBase
{
    [CascadingParameter(Name = "Theme")] public Theme? Theme { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> UnmatchedAttributes { get; set; } = new();

    [Parameter] public RenderFragment? ChildContent { get; set; }

    [Inject] protected ThemeProvider ThemeProvider { get; set; } = null!;

    protected Dictionary<string, object> Attributes => UnmatchedAttributes.Where(a => a.Key != "class").ToDictionary();
    protected string? ClassAttribute => UnmatchedAttributes.FirstOrDefault(a => a.Key == "class").Value?.ToString();
}