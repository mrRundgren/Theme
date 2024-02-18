using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace UiComponents.Theming;

public abstract class Theming
{
    public static class Layout
    {
        public const string App = nameof(ThemeProvider.App);
        public const string Drawer = nameof(ThemeProvider.Drawer);
        public const string Body = nameof(ThemeProvider.Body);
    }

    public static class Colors
    {
        public const string BgDefault = nameof(ThemeProvider.BgColorDefault);
        public const string FgDefault = nameof(ThemeProvider.FgColorDefault);
        public const string BgEmphasis = nameof(ThemeProvider.BgColorEmphasis);
        public const string FgEmphasis = nameof(ThemeProvider.FgColorEmphasis);
        public const string BgSubtle = nameof(ThemeProvider.BgColorSubtle);
        public const string FgSubtle = nameof(ThemeProvider.FgColorSubtle);
        public const string BgInset = nameof(ThemeProvider.BgColorInset);
        public const string FgInset = nameof(ThemeProvider.FgColorInset);
    }

    public static class Buttons
    {
        public const string Base = nameof(ThemeProvider.BaseButton);
        public const string Primary = nameof(ThemeProvider.PrimaryButton);
        public const string Secondary = nameof(ThemeProvider.SecondaryButton);
        public const string Danger = nameof(ThemeProvider.DangerButton);
        public const string Invisible = nameof(ThemeProvider.InvisibleButton);
        public const string Icon = nameof(ThemeProvider.IconButton);
    }

    public static class Effects
    {
        public const string Ripple = nameof(ThemeProvider.RippleEffect);
        public const string Focus = nameof(ThemeProvider.FocusEffect);
    }
}

public class ThemeProvider : IDisposable
{
    private readonly PersistentComponentState _state;
    private readonly PersistingComponentStateSubscription _subscription;

    public ThemeProvider(PersistentComponentState state)
    {
        _state = state;
        _subscription = _state.RegisterOnPersisting(OnPersisting, new InteractiveAutoRenderMode());

        BgColorDefault = FindInState(nameof(BgColorDefault), BgColorDefault);
        FgColorDefault = FindInState(nameof(FgColorDefault), FgColorDefault);
        BgColorEmphasis = FindInState(nameof(BgColorEmphasis), BgColorEmphasis);
        FgColorEmphasis = FindInState(nameof(FgColorEmphasis), FgColorEmphasis);
        BgColorSubtle = FindInState(nameof(BgColorSubtle), BgColorSubtle);
        FgColorSubtle = FindInState(nameof(FgColorSubtle), FgColorSubtle);
        BgColorInset = FindInState(nameof(BgColorInset), BgColorInset);
        FgColorInset = FindInState(nameof(FgColorInset), FgColorInset);
        BaseButton = FindInState(nameof(BaseButton), BaseButton);
        PrimaryButton = FindInState(nameof(PrimaryButton), PrimaryButton);
        SecondaryButton = FindInState(nameof(SecondaryButton), SecondaryButton);
        DangerButton = FindInState(nameof(DangerButton), DangerButton);
        InvisibleButton = FindInState(nameof(InvisibleButton), InvisibleButton);
        IconButton = FindInState(nameof(IconButton), IconButton);
        RippleEffect = FindInState(nameof(RippleEffect), RippleEffect);
        FocusEffect = FindInState(nameof(FocusEffect), FocusEffect);
        App = FindInState(nameof(App), App);
        Drawer = FindInState(nameof(Drawer), Drawer);
        Body = FindInState(nameof(Body), Body);
    }

    public string? BgColorDefault { get; init; }

    public string? FgColorDefault { get; init; }

    public string? BgColorEmphasis { get; init; }

    public string? FgColorEmphasis { get; init; }

    public string? BgColorSubtle { get; init; }

    public string? FgColorSubtle { get; init; }

    public string? BgColorInset { get; init; }

    public string? FgColorInset { get; init; }

    public string? BaseButton { get; init; }

    public string? PrimaryButton { get; init; }

    public string? SecondaryButton { get; init; }

    public string? DangerButton { get; init; }

    public string? InvisibleButton { get; init; }

    public string? IconButton { get; init; }

    public string? RippleEffect { get; init; }

    public string? FocusEffect { get; init; }

    public string? App { get; init; }

    public string? Drawer { get; init; }

    public string? Body { get; init; }

    public void Dispose()
    {
        _subscription.Dispose();
        GC.SuppressFinalize(this);
    }

    private Task OnPersisting()
    {
        _state.PersistAsJson(nameof(BgColorDefault), BgColorDefault);
        _state.PersistAsJson(nameof(FgColorDefault), FgColorDefault);
        _state.PersistAsJson(nameof(BgColorEmphasis), BgColorEmphasis);
        _state.PersistAsJson(nameof(FgColorEmphasis), FgColorEmphasis);
        _state.PersistAsJson(nameof(BgColorSubtle), BgColorSubtle);
        _state.PersistAsJson(nameof(FgColorSubtle), FgColorSubtle);
        _state.PersistAsJson(nameof(BgColorInset), BgColorInset);
        _state.PersistAsJson(nameof(FgColorInset), FgColorInset);
        _state.PersistAsJson(nameof(BaseButton), BaseButton);
        _state.PersistAsJson(nameof(PrimaryButton), PrimaryButton);
        _state.PersistAsJson(nameof(SecondaryButton), SecondaryButton);
        _state.PersistAsJson(nameof(DangerButton), DangerButton);
        _state.PersistAsJson(nameof(InvisibleButton), InvisibleButton);
        _state.PersistAsJson(nameof(IconButton), IconButton);
        _state.PersistAsJson(nameof(RippleEffect), RippleEffect);
        _state.PersistAsJson(nameof(FocusEffect), FocusEffect);
        _state.PersistAsJson(nameof(App), App);
        _state.PersistAsJson(nameof(Drawer), Drawer);
        _state.PersistAsJson(nameof(Body), Body);

        return Task.CompletedTask;
    }

    private string? FindInState(string key, string? value)
    {
        var found = _state.TryTakeFromJson<string>(key, out var foundValue);
        return found ? foundValue : value;
    }
}