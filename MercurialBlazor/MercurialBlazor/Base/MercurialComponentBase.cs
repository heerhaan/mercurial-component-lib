using MercurialBlazor.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MercurialBlazor;

public abstract class MercurialComponentBase : ComponentBase, IMercurialStateChanged
{
    [Parameter]
    public string? Class { get; set; }

    [Parameter]
    public string? Style { get; set; }

    [Parameter]
    public object? Tag { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object?> UserAttributes { get; set; } = [];

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
    }

    void IMercurialStateChanged.StateHasChanged() => StateHasChanged();
}
