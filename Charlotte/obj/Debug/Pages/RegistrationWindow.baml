   M S B A M L   `   `   `  ����D  @Charlotte, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Charlotte	Charlotte  5   	   "    Charlotte.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Charlotte     5   	     � Title$  Registration��5   	   $	��720��5	   	   $
��1280��6    � WindowState$ 	Maximized=�5
   	   ��5      �� 5   
    j� TileMode$
 None=�6    �� ImageSource 5      �� 5       �� 	UriSource$V PC:\\Users\\user\\source\\repos\\Charlotte\\Charlotte\\Images\\AuthBackground.jpg?�6   5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��6* �6   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ 	GoBackBtn��5   !   $��
Назад��6   $��20q�64   $��30(�6@   
�������
���   �$
��Left=�6t   6�   �� 5    
   $��1��6   $��1��6"   $��10q�62   .+�5!      �� $��
Логин��6   $��36(�6%   $��Bahnschrift)�63   $��Center=�6L   
������ 
�������6�   �� 5"      -   5         ��Name$ loginTextBox��5"   .   $��50��6   $	��600��6"   $��36(�6D   $��Bahnschrift)�6R   �� 5#      	 J� Opacity$	 0Q�6   $��20��6$   �� 5$      $��Пароль��6   $��36(�6&   $��Bahnschrift)�64   $��Center=�6M   
������ 
�������6�   G� 5%      -   5        
 G�Name$
 passwordBox��5%   2   $��50��6   $	��600��6&   $��36(�6G   �� 5&      $	 0Q�6   $��20��6$   �� 5'      $-��'Подтверждение пароля��6   $��36(�64   $��Bahnschrift)�6B   $��Center=�6[   
������ 
�������6�   G� 5(      -   5        $
 passwordBoxChecker��5(   2   $��50��6   $	��600��6&   $��36(�6N   �� 5)      $	 0Q�6   $��20��6$   �� 5*      $��Email��6   $��36(�6%   $��Bahnschrift)�63   $��Center=�6L   
������ 
�������6�   �� 5+      -   5        $ emailTB��5+   G   $��50��6   $	��600��6"   $��Bahnschrift)�6.   $��36(�6X   5,      �� 5-   
   $��2��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��Center=�6h   .+�5.      �� -   5        $ SignUpButton��5.   y   $*��$Зарегистрироваться��6   $��34(�62   
�������$��Bahnschrift)�6T   $��50��6m   6�   5/      50      51      