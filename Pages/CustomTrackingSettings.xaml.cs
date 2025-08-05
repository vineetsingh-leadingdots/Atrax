namespace TrackingApp1.Pages;

public partial class CustomTrackingSettings : ContentPage
{
	public CustomTrackingSettings()
	{
		InitializeComponent();
	}
    private async void OnSendClicked(object sender, EventArgs e)
    {
        
        string hours = HoursEntry.Text?.Trim();
        string phone = PhoneEntry.Text?.Trim();

        // Check if empty
        if (string.IsNullOrEmpty(hours) || string.IsNullOrEmpty(phone))
        {
            // Show popup
            await DisplayAlert("Input string empty",
                "Please check out Hours or Phone edit boxes, looks like boxes are empty!",
                "Ok");
        }
        else
        {
            await Navigation.PushAsync(new ConnectionSetup());

        }
    }
}
        