using Microsoft.Maui.Controls;

namespace TrackingApp1.Pages
{
    public partial class DriverMap : ContentPage
    {
        public DriverMap()
        {
            InitializeComponent();

            string html = @"
                <html>
                  <head>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                    <style>
                      html, body, iframe {
                        width: 100%;
                        height: 100%;
                        margin: 0;
                        padding: 0;
                        border: none;
                      }
                    </style>
                  </head>
                  <body>
                    <!-- You can only show 1 location at a time without API key -->
                    <iframe
                      src='https://maps.google.com/maps?q=28.644800,77.216721&z=12&output=embed'
                      allowfullscreen
                      loading='lazy'>
                    </iframe>
                  </body>
                </html>";

            MapWebView.Source = new HtmlWebViewSource
            {
                Html = html
            };
        }

        private async void OnBackTapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
