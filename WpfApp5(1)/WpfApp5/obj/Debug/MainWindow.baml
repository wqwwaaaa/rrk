   M S B A M L   `   `   `  ����B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	     � Title$   Практическая 4��5      $	��360��6   $	��400��6,    � WindowStartupLocation$ CenterScreen=�5	   	   $��Comic Sans MS)�5
   	    � WindowStyle$ 
ToolWindow=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   �� $��Задание 1��6   $��0��5      $��0��5      $��2��5      $��Center=�5      $��Center=�5       �� 5!   
   $��
День: ��6   $��1��5"      $��0��5#      $
��Left=�5$      $��Center=�5%      $��10q�5&      �� 5'   
   $��Месяц: ��6   $��2��5(      $��0��5)      $
��Left=�5*      $��Center=�5+      $��10q�5,      �� 5.   
   -   5         ��Name$ TextBlockAnswer��5.      $��Ответ: ��5/      $��3��50      $��0��51      $��2��52      $��Stretch=�53      $��Stretch=�54      $��10q�55      �� 56   
   -   5         ��Name$ 	TbNumberA��56      $��1��57      $��1��58      $��Center=�59      $
��10 0q�5:      $��1q�5;      �� 5<   
   -   5        $ 	TbNumberB��5<      $��2��5=      $��1��5>      $��Center=�5?      $
��10 0q�5@      $��1q�5A      �� 5B   
   $��4��6   $��0��5C      $��2��5D       �� Orientation$ 
Horizontal=�5E      $��Center=�5F      .+�5G      �� -   5        	 ��Name$	 BtnOK��5G      $��OK��6$   $��80��5H      $��24��6$   $��3q�60   
���� ��
�������5K      �� 5L      -   5        $	 	BtnCancel��5L      $��Cancel��6(   $��80��5M      $��24��6    $��3q�6,   
���� ��
�������5P      5Q      5R      5S      