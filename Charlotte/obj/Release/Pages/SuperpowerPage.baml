   M S B A M L   `   `   `  ���� D  @Charlotte, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Charlotte.PagesCharlotte.Pages  $    Charlotte.Pages.SuperpowerPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:Charlotte.Pages     -     � Title$  SuperpowerPage��$	��720��$
��1280�� � WindowState$ 	Maximized=�����  j� TileMode$
 None=� �� ImageSource ��  �� 	UriSource$V PC:\\Users\\user\\source\\repos\\Charlotte\\Charlotte\\Images\\MenuBackground.jpg?�.���  � RowDefinitions �� $	��100 ��� �� $	��160 � � ColumnDefinitions �� $��3* ��� .+��� -    ��Name$ 	GoBackBtn��$��
Назад��$��30q�$��30(�
�������
���   �$
��Left=��� $��1��
�������.+��� $��Описание��$��50(�$��Center=�$
��Bold"��� $
��Wrap=�$��20(����� *Description+�� $��1��$��1��
��������� $��2�����	#FF620039 �� Orientation$ 
Horizontal=�.+��� -   	 ��Name$	 CommentariesList�����	#FF620039$	��200��$	��550��$
��Left=�$��0q�$��Visible=����� 
 �� 
TargetType"
 �� �� Triggers P�  P� Property �@��
IsSelected P� Value . . ���  �� Property � �� �� Value
 ���� ��  � ��
 ���� .���  � |� .  ���� .R��� $ 
Horizontal=�$��10q�
�������.+��� $ 
Horizontal=�.+��� .+��� $ 
Horizontal=�.+��� 
���   �$��0 0 20 0q�$��20(����� *Date+�� 
���   �$��20(����� *Time+�� $��Center=�
���   �$��	0 10 0 10q�$��20(����� *
nameUser+�� $��Center=�$
��Wrap=�
���   �$��20(�$��50 0 0 0q�$	��407������ *Description+�� $	��100��
������ �� $��2��$��Right=�$��10q�.+��� -    ��Name$ commentaryFormTB��$	��100��$	��300���� -   $ createCommentaryBtn��$-��'Оставить комментарий��$��5q�
�������$��20(��� $��1��$��1�����	#FF620039.+��� $��1q�._��� $	��400��$	��200��$��0 30 0 0q����� *	MainImage+�� $��2��$��1��
�������$ 
Horizontal=�.+��� $ Vertical=�$��Center=�.+��� $��Название��$��20(�$��0 10 0 0q��� $��Center=�.+��� $��15(�$��	30 10 0 0q�$
��Wrap=����� *Name+