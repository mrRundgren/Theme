using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace UiComponents.Theming;

public abstract class Theming
{
    public static class Colors
    {
        public const string Background = nameof(ThemeProvider.BackgroundColor);
        public const string Text = nameof(ThemeProvider.TextColor);
    }
    public static class Buttons
    {
        public const string Primary = nameof(ThemeProvider.PrimaryButton);
        public const string Secondary = nameof(ThemeProvider.SecondaryButton);
        public const string Danger = nameof(ThemeProvider.DangerButton);
        public const string Invisible = nameof(ThemeProvider.InvisibleButton);
        public const string Icon = nameof(ThemeProvider.IconButton);
    }

    public static class Effects
    {
        public const string Ripple = nameof(ThemeProvider.RippleEffect);   
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

        BackgroundColor = FindInState(nameof(BackgroundColor), BackgroundColor);
        TextColor = FindInState(nameof(TextColor), TextColor);
        PrimaryButton = FindInState(nameof(PrimaryButton), PrimaryButton);
        SecondaryButton = FindInState(nameof(SecondaryButton), SecondaryButton);
        DangerButton = FindInState(nameof(DangerButton), DangerButton);
        InvisibleButton = FindInState(nameof(InvisibleButton), InvisibleButton);
        IconButton = FindInState(nameof(IconButton), IconButton);
        RippleEffect = FindInState(nameof(RippleEffect), RippleEffect);
    }

    public string? BackgroundColor { get; set; }
    
    public string? TextColor { get; set; }
    
    public string? PrimaryButton { get; set; }

    public string? SecondaryButton { get; set; }

    public string? DangerButton { get; set; }

    public string? InvisibleButton { get; set; }

    public string? IconButton { get; set; }

    public string? RippleEffect { get; set; }

    public void Dispose()
    {
        _subscription.Dispose();
        GC.SuppressFinalize(this);
    }

    private Task OnPersisting()
    {
        _state.PersistAsJson(nameof(PrimaryButton), PrimaryButton);
        _state.PersistAsJson(nameof(SecondaryButton), SecondaryButton);
        _state.PersistAsJson(nameof(DangerButton), DangerButton);
        _state.PersistAsJson(nameof(InvisibleButton), InvisibleButton);
        _state.PersistAsJson(nameof(IconButton), IconButton);
        _state.PersistAsJson(nameof(RippleEffect), RippleEffect);
        return Task.CompletedTask;
    }

    private string? FindInState(string key, string? value)
    {
        var found = _state.TryTakeFromJson<string>(key, out var foundValue);
        return found ? foundValue : value;
    }
}