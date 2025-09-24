using MauiTestApp.Services;

namespace MauiTestApp.Components.Pages;

public partial class Home
{
    public string Content = string.Empty;

    protected override void OnInitialized()
    {
        Content = SomeService.DoSomething();
    }
}