namespace TrackingApp1.Pages;

public partial class SetupNetworkConnection : ContentPage
{
    bool isPasswordHidden = true;
    public SetupNetworkConnection()
	{
		InitializeComponent();
        

    }
    private void OnEyeButtonClicked(object sender, EventArgs e)
    {
        isPasswordHidden = !isPasswordHidden;
        PasswordEntry.IsPassword = isPasswordHidden;
        EyeButton.Source = isPasswordHidden ? "eye_off.png" : "eye.png";
    }
    private async void OnConnectClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SelectVehicle());
    }

}

