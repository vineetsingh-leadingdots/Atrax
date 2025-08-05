namespace Atrax.Pages;

public partial class DeliveryStop : ContentPage
{
    public DeliveryStop()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync(); 
    }
    private async void OnSignatureClicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new SignaturePad());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }

}
