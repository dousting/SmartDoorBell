using Microsoft.Maui.Controls;

namespace SmartDoorBell
{
    public partial class LoginPage : ContentPage
    {
        // Define a hardcoded username and password for demonstration purposes
        private const string CorrectUsername = "user";
        private const string CorrectPassword = "password";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (username == CorrectUsername && password == CorrectPassword)
            {
                // Navigate to the main page if login is successful
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Login Failed", "Invalid username or password.", "OK");
            }
        }
    }
}
