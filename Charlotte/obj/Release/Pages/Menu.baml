   M S B A M L   `   `   `  ���� D  @Charlotte, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Charlotte	Charlotte      Charlotte.Menu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Charlotte     -     � Title$
  Menu��$	��720��$
��1280�� � WindowState$ 	Maximized=�����  j� TileMode$
 None=� �� ImageSource ��  �� 	UriSource$V PC:\\Users\\user\\source\\repos\\Charlotte\\Charlotte\\Images\\MenuBackground.jpg?�.���  � RowDefinitions �� $	��120 ��� $��80 ��� $��60 ���  � ColumnDefinitions �� �� �� .+��� $��2�� �� Orientation$ 
Horizontal=�$��Right=�
������ .+��� -    ��Name$ BtnExit��$��
Выйти��$��30q�$��30(�
�������
���   �$
��Left=��� -   $��40q�$��40(�
���   �
����������� *Login+A� -   $	��100��$	��100������  �� *Photo+�� $��1��
���   ��� $��2��
��������� $��2��$��1��
��������� $��1��$��1��
���   ��� $��2��$��2��
��������� $��1��$��2��
���   ��� -   $��2��$��
Герои��$��40(�$��Center=��� -   $��2��$��1��$&�� Суперспособности��$��40(�$��Center=��� -   $��2��$��2��$��Эпизоды��$��40(�$��Center=��� $��1��$��1��$'��!Популярные статьи��$��40(�
���   �
�������$��Center=�$��Center=��� -   	 ��Name$	 bestHeroesList��$��3������ .R��� $ Vertical=�.+��� $ 
Horizontal=�$��10q�.+��� $y�Hidden=����� *IdCharacter+�� $��Center=�$��20(����� *Name+�� $	��100��
 J� Opacity$
 0Q��� $��50��$	��100������ *	MainImage+�� $��5��$
 0Q��� -	   $	 bestSuperPowerList��$��3��$��1������ .R��� $ Vertical=�.+��� $ 
Horizontal=�$��10q�.+��� $��Center=�$��20(����� *Name+�� $	��100��$
 0Q�A� $	��100��$	��100������  �� *	MainImage+�� $��5��$
 0Q��� -
   $	 bestEpisodesList��$��3��$��2������ .R��� $ Vertical=�.+��� $ 
Horizontal=�$��0 0 0 0q�.+��� $��Center=�$��20(�$��0 50 0 0q����� *Title+�� $ 
Horizontal=�.+��� -   $ HelpBtn��$��Подсказка��$��30q�$��30(�
�������
���   �$
��Left=�