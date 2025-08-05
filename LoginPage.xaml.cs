namespace TrackingApp1;

public partial class LoginPage : ContentPage
{
    private bool isPasswordVisible = false;
    public LoginPage()
	{
		InitializeComponent();
	}
    private void OnTogglePasswordVisibility(object sender, EventArgs e)
    {
        isPasswordVisible = !isPasswordVisible;
        PasswordEntry.IsPassword = !isPasswordVisible;


        toggleButton.Source = isPasswordVisible ? "eye.png" : "eye_off.png";

    }
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        
        await Shell.Current.GoToAsync(nameof(Pages.LiveTracking));
    }
}