   M S B A M L   `   `   `  ���� D  @Charlotte, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Charlotte.PagesCharlotte.Pages  !    Charlotte.Pages.EpisodePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:Charlotte.Pages     -     � Title$  EpisodePage��$	��720��$
��1280�� � WindowState$ 	Maximized=�����  j� TileMode$
 None=� �� ImageSource ��  �� 	UriSource$V PC:\\Users\\user\\source\\repos\\Charlotte\\Charlotte\\Images\\MenuBackground.jpg?�.���  � RowDefinitions �� $	��100 ��� �� $	��160 � � ColumnDefinitions �� $��3* �.+��� -    ��Name$ 	GoBackBtn��$��
Назад��$��30q�$��30(�
�������
���   �$
��Left=��� $��1��
�������.+���  �� Orientation$ Vertical=�.+��� $��50(�$��	0 10 0 10q�$��Center=�$
��Bold"����� *Title+�� $
��Wrap=�$��10q�$��20(����� *Description+�� $��1��$��Bottom=�.+��� $��Изображения��$��20(�$��Center=�$
��Bold"��� -   	 ��Name$	 addictionalImagesLV��$��Bottom=�$��Center=����� 
 �� 
TargetType"
 �� �� Triggers P�  P� Property �@��
IsSelected P� Value . . ���  �� Property � �� �� Value
 ���� ��  � ��
 ���� .���  � |� .  ���� .R��  � Orientation$ 
Horizontal=����� .R��� $ 
Horizontal=�$��Center=�.+��� $	��100��$	��150������ *Photo+�� $��2�����	#FF00623B$ 
Horizontal=�.+��� -   $	 CommentariesList�����	#FF00623B$	��200��$	��550��$
��Left=�$��0q�$��Visible=����� "
 �� P�  �@��
IsSelected . . ���  � ��
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
������ �� $��2��$��Right=�$��100 10 0 0 q�.+��� -    ��Name$ commentaryFormTB��$	��100��$	��300���� -   $ createCommentaryBtn��$-��'Оставить комментарий��$��5q�
�������$��20(�