using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using System;
using Avalonia.Animation;
using Avalonia.Rendering.Composition;
using System.IO;
using Avalonia.Platform.Storage;
using System.Threading.Tasks;

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

        private async void OpenFileButton_Click(object? sender, RoutedEventArgs e)
        {
            // Get top level from the current control. Alternatively, you can use Window reference instead.
            var topLevel = TopLevel.GetTopLevel(this);

            // Start async operation to open the dialog.
            var files = await topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
            {
                Title = "Open Text File",
                AllowMultiple = false
            });

            if (files.Count >= 1)
            {
                // Open reading stream from the first file.
                await using var stream = await files[0].OpenReadAsync();
                using var streamReader = new StreamReader(stream);
                // Reads all the content of file as a text.
                var fileContent = await streamReader.ReadToEndAsync();
            }
        }
        
    }
}