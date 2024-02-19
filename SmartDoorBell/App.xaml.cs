using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace SmartDoorBell
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            // Set the login page as the initial page
            return new Window(new NavigationPage(new LoginPage()));
        }
    }
}
