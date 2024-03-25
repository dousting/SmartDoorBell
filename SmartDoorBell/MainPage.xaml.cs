using Microsoft.Maui.Controls;

namespace SmartDoorBell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LiveBtn_Clicked(object sender, EventArgs e)
        {
            // Handle Live button click event
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

        private void AccessBtn_Clicked(object sender, EventArgs e)
        {
            // Handle Access button click event
        }

        private void BackBtn_Clicked(object sender, EventArgs e)
        {
            // Handle Back button click event
        }
        private void OpenCameraButton_Clicked(object sender, EventArgs e)
        {
            // Navigate to the CameraPage
            Navigation.PushAsync(new CameraPage());
        }
    }
}
