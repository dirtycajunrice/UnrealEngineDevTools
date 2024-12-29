// // Copyright 2024 ${

using System.Windows;
using System.Windows.Controls;

namespace UnrealEngineDevTools.Views;

public partial class HomeView : UserControl
{
    public HomeView()
    {
        InitializeComponent();
    }
    
    private void myButton_Click(object sender, RoutedEventArgs e)
    {
        MyButton.Content = "Hello World!";
        // throw new NotImplementedException();
    }
}