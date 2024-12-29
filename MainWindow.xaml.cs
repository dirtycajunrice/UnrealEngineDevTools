using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UnrealEngineDevTools.Views;

namespace UnrealEngineDevTools;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainContentControl.Content = new HomeView();
    }
    
    // Show Home Page
    private void HomeButton_Click(object sender, RoutedEventArgs e)
    {
        MainContentControl.Content = new HomeView();
    }

    // Show Settings Page
    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
        MainContentControl.Content = new SettingsView();
    }

    // Show About Page
    private void AboutButton_Click(object sender, RoutedEventArgs e)
    {
        MainContentControl.Content = new AboutView();
    }
}