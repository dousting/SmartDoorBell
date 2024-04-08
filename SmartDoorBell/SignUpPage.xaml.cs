using Microsoft.Maui.Controls;

namespace SmartDoorBell
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            // Extract user inputs
            string name = NameEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            // Perform validation (e.g., check if fields are empty)

            // Example of sending data to the server for registration
            // You need to replace this with your actual implementation
            // bool signUpSuccessful = await YourApiService.RegisterUser(name, email, password);

            // Placeholder message
            await DisplayAlert("Success", "You have successfully signed up!", "OK");

            // For example, navigate to a login page
            await Navigation.PushAsync(new LoginPage());
        }

        private async void SignInLabel_Tapped(object sender, EventArgs e)
        {
            // Navigate to the login page when the sign-in label is tapped
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
