﻿using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;

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

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            // Handle cancel button click
        }

        // Event handler for light theme button
        private void OnLightThemeClicked(object sender, EventArgs e)
        {
            // Set light theme colors
            Application.Current.Resources["BackgroundColor"] = Colors.White;
            Application.Current.Resources["TextColor"] = Colors.Black;
        }

        // Event handler for dark theme button
        private void OnDarkThemeClicked(object sender, EventArgs e)
        {
            // Set dark theme colors
            Application.Current.Resources["BackgroundColor"] = Colors.Black;
            Application.Current.Resources["TextColor"] = Colors.White;
        }
    }
}
