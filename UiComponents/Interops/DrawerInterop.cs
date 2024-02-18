using Microsoft.JSInterop;

namespace UiComponents.Interops;

public class DrawerInterop(IJSRuntime jsRuntime) : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> _moduleTask = new(() =>
        jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/UiComponents/interops/drawerInterop.js")
            .AsTask());

    public async ValueTask DisposeAsync()
    {
        if (_moduleTask.IsValueCreated)
        {
            var module = await _moduleTask.Value;
            await module.DisposeAsync();
            GC.SuppressFinalize(this);
        }
    }

    public async ValueTask OpenAsync()
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("open");
    }
}