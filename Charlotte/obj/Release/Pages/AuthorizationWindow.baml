   M S B A M L   `   `   `  ���� D  @Charlotte, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Charlotte	Charlotte  #    Charlotte.AuthorizationWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Charlotte       � Title$  
MainWindow��$	��720��$
��1280�� � WindowState$ 	Maximized=�����  j� TileMode$
 None=� �� ImageSource ��  �� 	UriSource$V PC:\\Users\\user\\source\\repos\\Charlotte\\Charlotte\\Images\\AuthBackground.jpg?�.���  � ColumnDefinitions �� �� $��2* ���  � RowDefinitions �� �� $��2* ��� �� .+��� $��1��$��1��$��10q�.+��� $��
Логин��$��36(�$��Bahnschrift)�$��Center=�
������ 
��������� -    ��Name$ loginTextBox��$��50��$	��600��$��36(�$��Bahnschrift)���  J� Opacity$ 0Q�$��50���� $��Пароль��$��36(�$��Bahnschrift)�$��Center=�
������ 
�������G� -   	 G�Name$	 passwordBox��$��50��$	��600��$��36(��� $��2��$��1��
 �� Orientation$
 
Horizontal=�$��Center=�$��Center=�.+��� -    ��Name$ SignInButton��$��
Войти��$��34(�
�������$��Bahnschrift)�$��50��$	��100���� $ 0Q�$	��100���� -   $ SignUpButton��$��Регистрация��$��34(�
�������$��Bahnschrift)�$��50��