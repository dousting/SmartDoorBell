using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDoorBell
{
    public partial class CameraPage : ContentPage
    {
        public CameraPage()
        {
            //InitializeComponent();

            WebView webView = new WebView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            // Load the URL of the camera web server
            webView.Source = new UrlWebViewSource { Url = "http://192.168.45.92/" };

            // Create a Grid layout and add the WebView to it
            Grid grid = new Grid();
            grid.Children.Add(webView);

            // Set the Grid as the content of the page
            Content = grid;
        }
    }
}
