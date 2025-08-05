using Atrax.Pages;

namespace TrackingApp1.Pages;

public partial class StopsSummary : ContentPage
{
    public StopsSummary()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void OnArrivedClicked(object sender, EventArgs e)
    {
        ResetButtonColors();
        ArrivedButton.BackgroundColor = Colors.Black;
    }

    private async void OnCompletedClicked(object sender, EventArgs e)
    {
        ResetButtonColors();
        CompletedButton.BackgroundColor = Colors.Black;
        await Navigation.PushAsync(new DeliveryStop());
    }

    private void OnDetailsClicked(object sender, EventArgs e)
    {
        ResetButtonColors();
        DetailsButton.BackgroundColor = Colors.Black;
    }

    private void ResetButtonColors()
    {
        ArrivedButton.BackgroundColor = Colors.Gray;
        CompletedButton.BackgroundColor = Colors.Gray;
        DetailsButton.BackgroundColor = Colors.Gray;
    }
}
