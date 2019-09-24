// Editor.cs
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Threading;


using Microsoft.Win32;


namespace PodcastPlayer
{
    public partial class PlayerWindow : Window
    {
        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;
        private bool isMediaPlayerPaused = false;
        
        public PlayerWindow()
        {
            InitializeComponent();
            PopulateListBox();
            

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            //Create player
            
            
        }

        private void skip_30(object sender, EventArgs e)
        {
            mediaPlayer.Position = TimeSpan.FromSeconds(mediaPlayer.Position.TotalSeconds + 30);
        }

        private void skip_10(object sender, EventArgs e)
        {
            mediaPlayer.Position = TimeSpan.FromSeconds(mediaPlayer.Position.TotalSeconds - 10);
        }

        private void PopulateListBox()
        {
            string currentDir = Directory.GetCurrentDirectory();
            string[] podCasts = Directory.GetFiles(@"Media\", "*.mp3", SearchOption.AllDirectories);
            foreach (string pathName in podCasts)
            {
                listBox.Items.Add(currentDir + "\\" + pathName);
            }
        }

        private void LoadMedia()
        {
            var pod = (listBox.SelectedItem);
            if (listBox.SelectedItem != null)
            {
                Uri fileLoc = new Uri(@pod.ToString());
                mediaPlayer.Source = fileLoc;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            if ((mediaPlayer.Source != null) && (mediaPlayer.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                sliProgress.Minimum = 0;
                sliProgress.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                sliProgress.Value = mediaPlayer.Position.TotalSeconds;
                lblTotal.Text = TimeSpan.FromSeconds(sliProgress.Maximum).ToString(@"hh\:mm\:ss");
            }
        }
        private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {        
            var pod = (listBox.SelectedItem);
            Uri fileLoc = new Uri(@pod.ToString());
            mediaPlayer.Source = fileLoc;
         
        }

        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // MessageBox.Show("Mediaplayer Source " + (mediaPlayer.Source));            

            e.CanExecute = (mediaPlayer != null);
        }

        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (!isMediaPlayerPaused)
            {
                LoadMedia();
            }
            mediaPlayer.Play();
            mediaPlayerIsPlaying = true;
            
        }

        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isMediaPlayerPaused = true;
            mediaPlayer.Pause();
        }

        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }
        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mediaPlayer.Stop();
            mediaPlayerIsPlaying = false;
            isMediaPlayerPaused = false;
        }

        private void sliProgress_DragStarted(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }
        private void sliProgress_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            mediaPlayer.Position = TimeSpan.FromSeconds(sliProgress.Value);
        }
        private void sliProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblProgressStatus.Text = TimeSpan.FromSeconds(sliProgress.Value).ToString(@"hh\:mm\:ss");
        }

        private void refresh_clicked(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            PopulateListBox();   
        }        
    }
}