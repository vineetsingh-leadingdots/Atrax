using Microsoft.Maui.Controls;
using System;

namespace TrackingApp1.Pages
{
    public partial class LiveTracking : ContentPage
    {
        public LiveTracking()
        {
            InitializeComponent();
            PopupOverlay.IsVisible = true;
        }
        private void OnPopupOkClicked(object sender, EventArgs e)
        {
            PopupOverlay.IsVisible = false;
        }

        private async void OnDashCameraClicked(object sender, EventArgs e)
        {

            CameraErrorPopup.IsVisible = false;
            CameraWarningPopup.IsVisible = false;
            PopupOverlay.IsVisible = false;
            VideoSelectionScreen.IsVisible = true;

        }
        private void OnCameraWarningOkClicked(object sender, EventArgs e)
        {
            CameraWarningPopup.IsVisible = false;      
        }
        private void OnCameraPopupOkClicked(object sender, EventArgs e)
        {
            CameraErrorPopup.IsVisible = false;
            VideoSelectionScreen.IsVisible = true;
            CameraWarningPopup.IsVisible = true;

        }
        private void OnCancelVideoSelectionClicked(object sender, EventArgs e)
        {
            CameraWarningPopup.IsVisible = false;
            VideoSelectionScreen.IsVisible = false;
            
        }


        private async void OnTrackingSettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomTrackingSettings());
        }

        private void OnTruckSelected(object sender, EventArgs e)
        {
            string selectedTruck = TruckPicker.SelectedItem?.ToString();

            string latitude = "";
            string longitude = "";

            if (selectedTruck == "Truck 1")
            {
                latitude = "30.3398";
                longitude = "76.3869"; // Patiala
            }
            else if (selectedTruck == "Truck 2")
            {
                latitude = "28.7041";
                longitude = "77.1025"; // Delhi
            }
            else if (selectedTruck == "Truck 3")
            {
                latitude = "19.0760";
                longitude = "72.8777"; // Mumbai
            }

            if (!string.IsNullOrEmpty(latitude) && !string.IsNullOrEmpty(longitude))
            {
                string mapUrl = $"https://maps.google.com/maps?q={latitude},{longitude}&hl=es&z=14&output=embed";
                string htmlString = $@"
            <html>
              <body style='margin:0;padding:0;'>
                <iframe width='100%' height='100%' frameborder='0' style='border:0'
                  src='{mapUrl}' allowfullscreen>
                </iframe>
              </body>
            </html>";

                MapWebView.Source = new HtmlWebViewSource
                {
                    Html = htmlString
                };
            }
        }
    }
}
