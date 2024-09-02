using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Styling;
using System;

namespace AvaloniaLib1
{
    public class ImageWindow : Window
    {
        public ImageWindow(string imagePath)
        {
            Width = 800;
            Height = 450;
            Background = Brushes.Transparent;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ExtendClientAreaToDecorationsHint = true;
            ExtendClientAreaTitleBarHeightHint = 0;

            var closeButton = new Button
            {
                Width = 40,
                Height = 40,
                Content = new Image
                {
                    Source = new Bitmap("Assets/X.png"), 
                    Stretch = Stretch.Uniform,
                },
                Background = Brushes.Transparent,
                BorderBrush = Brushes.Transparent,
                HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(0, 0, 10, 10)
            };

            closeButton.Click += (sender, e) =>
            {
                Close();
            };

       
            var image = new Image
            {
                Width = 800,
                Height = 450,
                Source = new Bitmap(imagePath),
                Stretch = Stretch.Uniform
            };

       
            var container = new Grid();
            container.Children.Add(image);
            container.Children.Add(closeButton);

          
            Content = container;
        }
    }
}