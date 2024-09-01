using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Media;
using Avalonia.Controls.Shapes;

namespace AvaloniaLib1
{
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
          
            

        }

        private void CloseButtonClick(object? sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimiseButton_OnClick(object? sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExpandButton_OnClick(object? sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }


        private void League1(object? sender, RoutedEventArgs e)
        {
            string imagePath = "Assets/League/League1.png";

            var image = new Image
            {
                Width = 800,  // Set the desired width
                Height = 450, // Set the desired height
                Source = new Bitmap(imagePath),  // Use the relative path
                Stretch = Avalonia.Media.Stretch.Uniform
            };
            var messageBox = new Window
            {
                Title = "Login Error",
                Content = image, // Set the image as the content
                Width = 800,
                Height = 450,
                Background = Brushes.Transparent,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                
            
            };
            messageBox.ExtendClientAreaToDecorationsHint = true;
            messageBox.ExtendClientAreaTitleBarHeightHint = 0;
         ;
            messageBox.ShowDialog(this);
            
        }
    }
}