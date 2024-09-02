using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using System.Collections.Generic;

namespace AvaloniaLib1
{
    public partial class Dashboard : Window
    {
        private  Dictionary<string, string> _leagueImages = new()
        {
            { "League1", "Assets/League/League1.png" },
            { "League2", "Assets/League/League2.png" },
            { "League3", "Assets/League/League3.png" },
            { "League4", "Assets/League/League4.png" },
            { "League5", "Assets/League/League5.png" },
            { "League6", "Assets/League/League6.png" },
            { "League7", "Assets/League/League7.png" },
            { "League8", "Assets/League/League8.png" },
            { "League9", "Assets/League/League9.png" },
            {"League10","Assets/League/League10.png"}
            
        };

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
            this.WindowState = this.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }

        private void OpenImageWindow(string imagePath)
        {
            var imageWindow = new ImageWindow(imagePath);
            imageWindow.ShowDialog(this);
        }

        private void LeagueButtonClick(object? sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is string leagueKey && _leagueImages.TryGetValue(leagueKey, out var imagePath))
            {
                OpenImageWindow(imagePath);
            }
        }
    }
}