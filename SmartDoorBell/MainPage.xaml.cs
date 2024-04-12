using System;
using Microsoft.Maui.Controls;

namespace SmartDoorBell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false); // Hide the navigation bar
        }

        // Event handler for the settings button click
        private void SettingsBtn_Clicked(object sender, EventArgs e)
        {
            // Handle the settings button click event here
            // For example, you can navigate to a settings page
            //Navigation.PushAsync(new SettingsPage());
        }

        // Other event handler methods for other buttons can be defined here
        private void LiveBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CameraPage());
        }

        private void PlaybackBtn_Clicked(object sender, EventArgs e)
        {
            // Handle Playback button click event
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            // Handle Add button click event
        }

        private void AlarmBtn_Clicked(object sender, EventArgs e)
        {
            // Handle Alarm button click event
        }

        private void OpenCameraButton_Clicked(object sender, EventArgs e)
        {
            // Navigate to the CameraPage
            Navigation.PushAsync(new CameraPage());
        }
    }
}
