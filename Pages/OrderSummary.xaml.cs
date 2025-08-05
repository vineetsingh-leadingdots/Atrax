using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;

namespace TrackingApp1.Pages;

public partial class OrderSummary : ContentPage
{
    public OrderSummary(bool showPopupAfterDelay = false)
    {
        InitializeComponent();

        if (showPopupAfterDelay)
        {
            ShowPopupWithDelay();
        }
    }

    private async void OnMapClicked(object sender, EventArgs e)
    {
        MapButton.BackgroundColor = Colors.Black;
        await Navigation.PushAsync(new DriverMap());


    }
    private void ShowPopup(object sender, EventArgs e)
    {
        PopupOverlay.IsVisible = true;
    }

    private void ClosePopup(object sender, EventArgs e)
    {
        PopupOverlay.IsVisible = false;
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private async void ShowPopupWithDelay()
    {
        await Task.Delay(1000);
        PopupOverlay.IsVisible = true;
    }
    bool isLastItemSelected = false;

    private void OnLastOrderTapped(object sender, EventArgs e)
    {
        isLastItemSelected = true;

        // Black background and white text
        LastOrderFrame.BackgroundColor = Colors.Black;
        LastOrderCompanyLabel.TextColor = Colors.White;
        LastOrderCodeLabel.TextColor = Colors.White;
        LastOrderStatusLabel.TextColor = Colors.White;

        // Show Start button, hide Next
        StartButton.IsVisible = true;
        StartButton.BackgroundColor = Colors.Gray;

        NextButton.IsVisible = false;
    }

    private void OnAlertCancelClicked(object sender, EventArgs e)
    {
        AlertPopup.IsVisible = false;
        StartButton.BackgroundColor = Colors.Gray; //  reset back
    }

    private void OnAlertOkClicked(object sender, EventArgs e)
    {
        AlertPopup.IsVisible = false;

        // A000044 ke right side me status dikhana (ERT ya ONS)
        LastOrderStatusLabel.Text = "ERT"; // ya "ONS", depending on logic

        // Start hatao, Next dikhayo
        StartButton.IsVisible = false;
        NextButton.IsVisible = true;

        // Reset colors if needed
        StartButton.BackgroundColor = Colors.Gray;

        LastOrderFrame.BackgroundColor = Colors.LightGray; // or "#f2f2f2" if you want it same as others
        LastOrderCompanyLabel.TextColor = Colors.Black;
        LastOrderCodeLabel.TextColor = Colors.Black;
        LastOrderStatusLabel.TextColor = Colors.Black;

    }

    private void OnStartClicked(object sender, EventArgs e)
    {
        if (isLastItemSelected)
        {
            AlertPopup.IsVisible = true;

            // Change start button to black when clicked
            StartButton.BackgroundColor = Colors.Black;
        }
    }

    private async void OnNextClicked(object sender, EventArgs e)
    {
        // For now, just switch to "Start" button same as order tapped logic
        isLastItemSelected = true;

        LastOrderFrame.BackgroundColor = Colors.Black;
        LastOrderCompanyLabel.TextColor = Colors.White;
        LastOrderCodeLabel.TextColor = Colors.White;
        LastOrderStatusLabel.TextColor = Colors.White;

        NextButton.IsVisible = false;
        StartButton.IsVisible = true;
        StartButton.BackgroundColor = Colors.Black;

        MapButton.BackgroundColor = Colors.Gray;
        await Navigation.PushAsync(new StopsSummary());
    }


}
