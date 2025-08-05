using TrackingApp1.Pages; 

namespace TrackingApp1.Pages;

public partial class ConnectionSetup : ContentPage
{
	public ConnectionSetup()
	{
		InitializeComponent();
	}
    private void OnShowPopupClicked(object sender, EventArgs e)
    {
        PopupOverlay.BackgroundColor = Color.FromArgb("#80000000");
        PopupOverlay.IsVisible = true;
    }

    private void OnHidePopupClicked(object sender, EventArgs e)
    {

        PopupOverlay.IsVisible = false;
        PopupOverlay.BackgroundColor = Colors.Transparent;
    }
    private async void OnSetupConnectionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SetupNetworkConnection());
    }

}
