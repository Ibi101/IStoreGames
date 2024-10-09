using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using System.Collections.Generic;
using Avalonia.Rendering.Composition;
using System.IO;
using Avalonia.Platform.Storage;
using System.Threading.Tasks;
using Avalonia;
using System;
using Avalonia.Animation;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;

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
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

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

        private void LargeImageWindow(Bitmap bitmap)
        {
            var LargeImageWindow = new Window
            {
                Height = 600,
                Width = 400,
                Background = Brushes.Transparent,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ExtendClientAreaToDecorationsHint = true,
                ExtendClientAreaTitleBarHeightHint = 0,
            };
            var grid = new Grid();
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
            closeButton.Click += (s, e) => LargeImageWindow.Close();
                
            grid.Children.Add(closeButton); 
            grid.Children.Add(new Image
            {
                Source = bitmap, Stretch = Avalonia.Media.Stretch.Uniform,
           
            });

      
            LargeImageWindow.Content = grid;

            LargeImageWindow.Show(); 


        }

        private async void AddImageButton(object? sender, RoutedEventArgs e)
        {
            var topLevel = TopLevel.GetTopLevel(this);

            var files = await topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
            {
                Title = "File Explorer",
                AllowMultiple = true
            });

            foreach (var file in files)
            {
                await using var stream = await file.OpenReadAsync();
                var bitmap = new Bitmap(stream);

                // Get the selected panel from the ComboBox
                var selectedPanel = PanelSelect.SelectedItem as ComboBoxItem;
                if (selectedPanel != null)
                {
                    var panelName = selectedPanel.Content.ToString();
                    var panel = this.FindControl<Panel>(panelName);
                    if (panel != null)
                    {
                        // Create a new button instance for the selected panel
                        var newButton = new Button
                        {
                            Width = 200,
                            Height = 150,
                            Content = new Image
                            {
                                Source = bitmap,
                                Width = 200,
                                Height = 150
                            }
                        };

                        newButton.Click += (s, args) => LargeImageWindow(bitmap);
                        panel.Children.Insert(0, newButton);
                    }
                }
            }
        }

    }
}