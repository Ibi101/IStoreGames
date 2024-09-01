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
                // Ensure the image path is correct and the file exists
                // Ensure the path is correct relative to the output directory
                string imagePath = "Assets/X.png";

                var image = new Image
                {
                    Width = 100,  // Set the desired width
                    Height = 100, // Set the desired height
                    Source = new Bitmap(imagePath),  // Use the relative path
                    Stretch = Avalonia.Media.Stretch.Uniform
                };

                var messageBox = new Window
                {
                    Title = "Login Error",
                    Content = image, // Set the image as the content
                    Width = 350,
                    Height = 200,
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