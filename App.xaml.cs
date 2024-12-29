using System.Windows;
using Settings = UnrealEngineDevTools.Properties.Settings;

namespace UnrealEngineDevTools
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Override OnStartup to call SetTheme when the app starts
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        
            // Get user preference from settings
            var savedTheme = Settings.Default.Theme;
        
            // Apply the saved theme (or fall back to a default if none is saved)
            SetTheme(string.IsNullOrEmpty(savedTheme) ? "Dark" : savedTheme);
        }
    
        private void SetTheme(string theme)
        {
            var resourceDict = new ResourceDictionary
            {
                Source = new Uri("Resources/Themes/" + (theme == "Dark" ? "Dark" : "Light") + ".xaml", UriKind.Relative)
            };

            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(resourceDict);
        }
    
        public void ChangeTheme(string theme)
        {
            SetTheme(theme);

            // Save to settings for persistence
            Settings.Default.Theme = theme;
            Settings.Default.Save();
        }
    }
}

