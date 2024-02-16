using Microsoft.AspNetCore.Components;
using UiComponents.Theming;

namespace UiComponents.Core;

public class UiComponentBase : ComponentBase
{
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> UnmatchedAttributes { get; set; } = new();

    [Parameter] public RenderFragment? ChildContent { get; set; }

    [Inject] protected ThemeProvider Theme { get; set; } = null!;

    protected Dictionary<string, object> Attributes => UnmatchedAttributes.Where(a => a.Key != "class").ToDictionary();
    protected string? ClassAttribute => UnmatchedAttributes.FirstOrDefault(a => a.Key == "class").Value?.ToString();
}