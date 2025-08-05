using System;
using Microsoft.Maui.Controls;
using TrackingApp1.Pages;

namespace TrackingApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(LiveTracking), typeof(Pages.LiveTracking));
    }
}
