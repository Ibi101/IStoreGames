using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using System;

namespace AvaloniaLib1.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void LogInButton_OnClick(object? sender, RoutedEventArgs e)
        {
            if (LogInTextBox.Text == "ibi" && PassowordTextBox.Text == "2005")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
            else
            {
                
                

                var messageBox = new Window
                {
                    Title = "Login Error",
                    Content = "Invalid UserName or Password",
                    Width = 220,
                    Height = 150,
                    WindowStartupLocation = WindowStartupLocation.CenterScreen
                };

                messageBox.ShowDialog(this);
            }
        }

        private void CloseButtonClick(object? sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}