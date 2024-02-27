namespace Pico;

public class PrimaryButton : Button
{
    protected override string CssClass => Inactive ? Theme.InactiveButtonCss : Theme.PrimaryButtonCss;
}

public class SecondaryButton : Button
{
    protected override string CssClass => Inactive ? Theme.InactiveButtonCss : Theme.SecondaryButtonCss;
}

public class DangerButton : Button
{
    protected override string CssClass => Inactive ? Theme.InactiveButtonCss : Theme.DangerButtonCss;
}

public class InvisibleButton : Button
{
    protected override string CssClass => Inactive ? Theme.InactiveButtonCss : Theme.InvisibleButtonCss;
}

public class IconButton : Button
{
    protected override string CssClass => Inactive ? Theme.InactiveButtonCss : Theme.IconButtonCss;
}