using Microsoft.UI.Xaml;
using Microsoft.UI.Windowing;

using System;
using Windows.Graphics;
using WinRT.Interop;
using Microsoft.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TrackingApp1.WinUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : MauiWinUIApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);

            var window = Microsoft.Maui.Controls.Application.Current?.MainPage?.Handler?.PlatformView as Microsoft.UI.Xaml.Window;
            if (window != null)
            {
                IntPtr hwnd = WindowNative.GetWindowHandle(window);
                WindowId windowId = Win32Interop.GetWindowIdFromWindow(hwnd);
                AppWindow appWindow = AppWindow.GetFromWindowId(windowId);

                

                
                appWindow.TitleBar.ExtendsContentIntoTitleBar = true;
            }
            }
        }

}
