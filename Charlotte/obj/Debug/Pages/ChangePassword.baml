   M S B A M L   `   `   `  ����D  @Charlotte, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Charlotte.PagesCharlotte.Pages  5   	   $    Charlotte.Pages.ChangePassword   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Charlotte.Pages     5   	     � Title$  Change password��5   	   $	��400��6!   $	��800��6.   ��5
      �� 5   
    j� TileMode$
 None=�6    �� ImageSource 5      �� 5       �� 	UriSource$V PC:\\Users\\user\\source\\repos\\Charlotte\\Charlotte\\Images\\MenuBackground.jpg?�6   5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   �� -   5         ��Name$ 	GoBackBtn��5   !   $��
Назад��6   $��10q�64   $��20(�6@   
�������
���   �$
��Left=�6t   6�   �� 5   
   $��1��6   
������� �� Orientation$ 
Horizontal=�65   .+�5      �� $��20q�6   .+�5      �� $!��Текущий пароль��6   $��30(�62   $��	 0 0 0 40q�6@   6U   �� 5      $��Новый пароль��6   $��30(�60   $��	 0 0 0 40q�6>   6S   �� 5      $-��'Подтверждение пароля��6   $��30(�68   $��	 0 0 0 40q�6F   6[   5      �� 5      $��20��6    J� Opacity$ 0Q�6#   �� 5      $��20q�6   .+�5      G� -   5         G�Name$ currentPassword��5      $��30(�67   $��	 0 0 0 30q�6E   $	��350��6X   6f   G� 5       -   5        $ newPassword��5       $��30(�64   $��	 0 0 0 35q�6B   6W   G� 5!      -   5        $ newPasswordAccept��5!      $��30(�69   $��	 0 0 0 40q�6G   6\   5"      5#      �� 5$   
   -   5        $ ChangePasswordBtn��5$      $��1��6,   $#��Изменить пароль��69   $	��400��6S   $��50��6_   $��Bottom=�6k   $��0 0 0 20q�6�   
���   �$��30(�6�   
�������6�   5%      5&      