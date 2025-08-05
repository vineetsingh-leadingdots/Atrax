using TrackingApp1.Pages;

namespace TrackingApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new AppShell());

#if WINDOWS
        window.Width = 900;
        window.Height = 850; //695
#endif

        return window;
    }
}