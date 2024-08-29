using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Tmds.DBus.Protocol;
using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaLib1.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        WindowStartupLocation = WindowStartupLocation.CenterScreen;
    
       
    }

    private void LogInButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if (LogInTextBox.Text =="ibi"&& PassowordTextBox.Text =="2005")
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
                Content = new TextBlock
                {
                    Text = "Please the correct  username and password.",
                  
                },
                FontSize = 15,
                Width = 350,
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