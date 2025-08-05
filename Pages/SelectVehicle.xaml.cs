namespace TrackingApp1.Pages;

public partial class SelectVehicle : ContentPage
{
	public SelectVehicle()
	{
		InitializeComponent();
	}
    private async void OnSendClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummary(showPopupAfterDelay: true)); 
    }
  

}