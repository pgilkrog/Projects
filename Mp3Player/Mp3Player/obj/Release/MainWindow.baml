   M S B A M L   `   `   `  ���� D  @Mp3Player, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Mp3Player	Mp3Player      Mp3Player.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Mp3Player       � Title$  Music Player��$	��700��$	��810�����#111 � 
ResizeMode$ CanMinimize=�.��� .+�R� -   $��TreeList��$
��Left=�$	��534��$��	10,10,0,0q�$	��Top=�$	��175�����#111����  �� ItemsSource ��  �� Path$ Albums�.R��� ���#ef3e7e���� $ 
ArtistName� �� ItemTemplate �� .R��� ���#f1558d���� $ 	AlbumName��� -   $��	SongsList��$
��Left=�$	��534��$��
200,10,0,0q�$	��Top=�$	��584�����#111���#f1558d �� View �� .P��� $
��Song�� �� Width$
 Auto�� �� DisplayMemberBinding �� $
 Name��� $��Artist��$
 Auto�� �� $ Directory.Parent.Name��� $��Album��$
 Auto�� �� $ Directory.Name��� -   $��btnPlay��$
��Left=�$��371,610,0,0q�$	��Top=�$��50��
������ 
������  � ToolTip$
 Play��.���� -   $��imgPlay��$��Images/play.png���� -   $��btnStop��$
��Left=�$��280,612,0,0q�$	��Top=�$��45��$��1��$
 Stop��
������ 
������ .���� $��Images/stop.png���� -   $��Backward��$��1��$
��Left=�$��325,612,0,0q�$	��Top=�$��45��$ Previous��
������ 
������ .���� $��Images/next.PNG��	 J� RenderTransformOrigin$	 0.5,0.5&�z��� 
 �� ScaleX$
 -1Q��� -   $��Forward��$��1��$
��Left=�$��422,612,0,0q�$	��Top=�$��45��$
 Next��
������ 
������ .���� $��Images/next.png���� -   $��	btnRepeat��$
��Left=�$��200,607,0,0q�$��50��$	��Top=�$ Repeat��
������ 
������ .���� -	   $��	imgRepeat��$��Images/repeat.png���� -
   $��
btnShuffle��$
��Left=�$��150,607,0,0q�$��50��$	��Top=�$ Shuffle��
������ 
������ .���� -   $��
imgShuffle��$��Images/shuffle.png���� -   $��	btnVolume��$
��Left=�$��472,616,0,0q�$��40��$	��Top=�$ Volume on/off��
������ 
������ .���� -   $��	imgVolume��$��Images/volumeOn.png��� -   $��MusicProgress��$
��Left=�$��12��$��
10,549,0,0q�$	��Top=�$	��775�����#ed266e���#333�� -   $��sliderVolume��$
��Left=�$��515,626,0,0q�$	��Top=�$	��200�� �� IsMoveToPointEnabled . �� -   $��lblCurrentlyPlatying��$��Currently Playing:��$
��Left=�$��
10,574,0,0q�$	��Top=�$	��264�����	#FFD4D4D4�� -   $��lblSongTimer��$��00:00/00:00��$
��Left=�$��360,574,0,0q�$	��Top=����	#FFD8D8D8