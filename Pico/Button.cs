using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Pico;

public class Button : ComponentBase
{
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> UnmatchedAttributes { get; set; } = new();

    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter] public string Tag { get; set; } = "button";
    [Parameter] public string? Text { get; set; }
    [Parameter] public Direction Direction { get; set; } = Direction.Ltr;
    protected virtual string CssClass => "";
    private Dictionary<string, object> Attributes => UnmatchedAttributes.Where(a => a.Key != "class").ToDictionary();
    private string? ClassAttribute => UnmatchedAttributes.FirstOrDefault(a => a.Key == "class").Value?.ToString();

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var sequence = 0;
        List<string?> classes = [ClassAttribute, CssClass, $"direction-{Direction.ToString().ToLowerInvariant()}"];

        builder.OpenElement(sequence++, Tag);
        builder.AddMultipleAttributes(sequence++, Attributes);
        builder.AddAttribute(sequence++, "class", string.Join(" ", classes));

        if (Text is not null)
        {
            builder.OpenElement(sequence++, "div");
            builder.AddAttribute(sequence++, "class", "btn__text");
            builder.AddContent(sequence++, Text);
            builder.CloseElement();
        }

        if (ChildContent is not null)
        {
            builder.AddContent(sequence, ChildContent);
        }

        builder.CloseElement();
    }
}

public class PrimaryButton : Button
{
    protected override string CssClass => "btn btn-primary";
}

public class SecondaryButton : Button
{
    protected override string CssClass => "btn btn-secondary";
}

public class DangerButton : Button
{
    protected override string CssClass => "btn btn-danger";
}

public class InvisibleButton : Button
{
    protected override string CssClass => "btn btn-invisible";
}

public class IconButton : Button
{
    protected override string CssClass => "btn btn-icon";
}