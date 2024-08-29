using Avalonia.Controls;
using Avalonia.Interactivity;

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
    }
}