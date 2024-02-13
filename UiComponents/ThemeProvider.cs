using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace UiComponents;

public class ThemeProvider : IDisposable
{
    private readonly PersistentComponentState _state;
    private PersistingComponentStateSubscription _subscription;

    public ThemeProvider(PersistentComponentState state)
    {
        _state = state;
        _subscription = _state.RegisterOnPersisting(OnPersisting, new InteractiveAutoRenderMode());

        PrimaryButton = FindInState(nameof(PrimaryButton), PrimaryButton);
        SecondaryButton = FindInState(nameof(SecondaryButton), SecondaryButton);
        DangerButton = FindInState(nameof(DangerButton), DangerButton);
        InvisibleButton = FindInState(nameof(InvisibleButton), InvisibleButton);
        IconButton = FindInState(nameof(IconButton), IconButton);
    }

    public string? PrimaryButton { get; set; }

    public string? SecondaryButton { get; set; }

    public string? DangerButton { get; set; }

    public string? InvisibleButton { get; set; }

    public string? IconButton { get; set; }

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
        return Task.CompletedTask;
    }

    private string? FindInState(string key, string? value)
    {
        var found = _state.TryTakeFromJson<string>(key, out var foundValue);
        return found ? foundValue : value;
    }
}