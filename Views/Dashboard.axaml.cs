using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using System.Collections.Generic;

namespace AvaloniaLib1
{
    public partial class Dashboard : Window
    {
        private Dictionary<string, string> _leagueImages = new()
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
            { "League10", "Assets/League/League10.png" }
        };

        private Dictionary<string, string> PoeImages = new()
        {
            {"Poe1", "Assets/Poe/Poe1.png"},
            {"Poe2", "Assets/Poe/Poe2.png"},
            {"Poe3", "Assets/Poe/Poe3.png"},
            {"Poe4", "Assets/Poe/Poe4.png"},
            {"Poe5", "Assets/Poe/Poe5.png"},
            {"Poe6", "Assets/Poe/Poe6.png"},
            {"Poe7", "Assets/Poe/Poe7.png"},
            {"Poe8", "Assets/Poe/Poe8.png"},
            {"Poe9", "Assets/Poe/Poe9.png"},
            {"Poe10", "Assets/Poe/Poe10.png"}
        };

        private Dictionary<string, string> RobloxImages = new()
        {
            {"Roblox1", "Assets/Roblox/Roblox1.png"},
            {"Roblox2", "Assets/Roblox/Roblox2.png"},
            {"Roblox3", "Assets/Roblox/Roblox3.png"},
            {"Roblox4", "Assets/Roblox/Roblox4.png"},
            {"Roblox5", "Assets/Roblox/Roblox5.png"},
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

        private void PoeButtononClick(object? sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is string Poekey && PoeImages.TryGetValue(Poekey, out var imagePath))
            {
                OpenImageWindow(imagePath);
            }
        }
        private void RobloxButtonClick(object? sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is string Robloxkey && RobloxImages.TryGetValue(Robloxkey, out var imagePath))
            {
                OpenImageWindow(imagePath);
            }
        }
    }
}