   M S B A M L   `   `   `  ����  podcast_player     PodcastPlayer.PlayerWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $	��600��5      $	��475��5        � Icon$F  @C:/Users/misikp/Downloads/C# Dev/podcast_player/podcast_icon.ico��5	       � Title$ Podcast Player��5
       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ MediaCommands.Play��5      6S     5   
   -   5        $ MediaCommands.Pause��5      6U     5   
   -   5        $ MediaCommands.Stop��5      6S   .��5      �� $��Center=�5   	   .+�5   
   r� -   5         r�Name$ mediaPlayer��5       r� LoadedBehavior$ Manual=�5      $	��Top=�5      �� 5   
   -   5        $��listBox��5      $��5,5,5,5q�5      $
��Left=�5      $	��Top=�5      $	��350��5       �� 5&   
   ��5'      �� 5(      .R�5)      �  � ColumnDefinitions 5*      �� 5+      $
��Auto �6/   �� 5,      $��* �6/   �� 5-      $
��Auto �6/   5/      50      .@�52      �� .��53      �� -   5        $��lblProgressStatus��53      
00:00:006?   54      �� 55      $��1��6   $��Stretch=�6,   .��56      �� -   5        $��sliProgress��56      6�   57      �� 58      $��2��6   .��59      �� -   5        $��lblTotal��59      
00:00:0066   5:      5;      c� 5=   
   
������� `� IsLocked . .@�5@      �� -	   5        .��5A      �� $F��@C:/Users/misikp/Downloads/C# Dev/podcast_player/Buttons/left.png��6   5B      �� 5C      $��MediaCommands.Play��6   $��0q�62   .��5D      �� $F��@C:/Users/misikp/Downloads/C# Dev/podcast_player/Buttons/play.png��6   5E      �� 5G      $��MediaCommands.Pause��6   $��0q�63   .��5H      �� $G��AC:/Users/misikp/Downloads/C# Dev/podcast_player/Buttons/pause.png��6   5I      �� 5K      $��MediaCommands.Stop��6   $��0q�62   .��5L      �� $F��@C:/Users/misikp/Downloads/C# Dev/podcast_player/Buttons/stop.png��6   5M      �� 5N      -
   5        $��0q�5O   )   .��5P      �� $I��CC:/Users/misikp/Downloads/C# Dev/podcast_player/Buttons/refresh.png��6   5Q      �� 5R      -   5        $��0q�5R   %   .��5S      �� $G��AC:/Users/misikp/Downloads/C# Dev/podcast_player/Buttons/right.png��6   5T      5U      5V      5X      