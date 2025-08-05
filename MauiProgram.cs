using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using CommunityToolkit.Maui;
using SkiaSharp.Views.Maui.Controls.Hosting;


namespace TrackingApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            MauiAppBuilder mauiAppBuilder = builder
                .UseMauiApp<App>()

                .UseMauiCommunityToolkit()
                .UseSkiaSharp()

                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
             



            return builder.Build();
        }
    }
}
