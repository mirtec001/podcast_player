//Editor_form.cs
using System;
using System.Windows;
using System.Windows.Controls;


namespace PodcastPlayer
{
    public partial class PlayerApp : Application
    {
        void AppStartup(object sender, StartupEventArgs e)
        {
        // By default, when all top level windows
        // are closed, the app shuts down
        Window window = new PlayerWindow();
        window.Show();
        }
    }
}