   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp6WpfApp6  5   	       WpfApp6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp6     5   	     � Title$   Практическая 4��5   	   $	��360��6    $	��400��6-    � WindowStartupLocation$ CenterScreen=�5	   	   $��Comic Sans MS)�5
   	    � WindowStyle$ 
ToolWindow=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   �� $��Задание 4��6   $��0��5      $��0��5      $��2��5      $��Center=�5      $��Center=�5      �� 5   
   $��Число N: ��6   $��1��5       $��0��5!      $
��Left=�5"      $��Center=�5#      $��10q�5$      �� 5%   
   $��Число K: ��6   $��2��5&      $��0��5'      $
��Left=�5(      $��Center=�5)      $��10q�5*      �� 5+   
   -   5         ��Name$ TextBlockAnswer��5+      $��Ответ: ��5,      $��3��5-      $��0��5.      $��2��5/      $��Stretch=�50      $��Stretch=�51      $��10q�52      �� 53   
   -   5         ��Name$ 	TbNumberA��53      $��1��54      $��1��55      $��Center=�56      $
��10 0q�57      $��1q�58      �� 59   
   -   5        $ 	TbNumberB��59      $��2��5:      $��1��5;      $��Center=�5<      $
��10 0q�5=      $��1q�5>      �� 5?   
   $��4��6   $��0��5@      $��2��5A       �� Orientation$ 
Horizontal=�5B      $��Center=�5C      .+�5D      �� -   5        	 ��Name$	 BtnOK��5D      $��OK��6$   $��80��5E      $��24��6$   $��3q�60   
���� ��
�������5H      �� 5I      -   5        $	 	BtnCancel��5I      $��Cancel��6(   $��80��5J      $��24��6    $��3q�6,   
���� ��
�������5M      5N      5O      5P      