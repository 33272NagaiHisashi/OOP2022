   M S B A M L   `   `   `  ���� G  CColorChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ColorCheckerColorChecker      ColorChecker.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:ColorChecker     -     � Title$  
MainWindow��$	��600��$
��1000��.��� $��0,0,0,4q� � ColumnDefinitions �� $��* ��� $��* ��� $��* �.+��� -    ��Name$ lColor��$��50,50,50,50q�� $��1�� � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��R��$��50(�$��Center=�$��Center=�$��1���� -    ��Name$
 sRed�� � Maximum$	 255Q� �� IsSnapToTickEnabled .  �� TickFrequency$ 1Q�$��1��$��1��$��3��$��Center=��� -    ��Name$ tbRed��$��1��$��4��$��30(�$��Center=�$��Center=����� 	 �� ElementName$
	 sRed��
 �� Path$
 Value� �� UpdateSourceTrigger$ PropertyChanged=��� $��G��$��50(�$��Center=�$��Center=�$��2���� -   $ sGreen��$	 255Q� . $ 1Q�$��2��$��1��$��3��$��Center=��� -   $ tbGreen��$��2��$��4��$��30(�$��Center=�$��Center=����� $	 sGreen��$
 Value�$ PropertyChanged=��� $��B��$��50(�$��3��$��Center=�$��Center=��� -   $ sBlue��$	 255Q� . $ 1Q�$��3��$��1��$��3��$��Center=��� -   $ tbBlue��$��3��$��4��$��30(�$��Center=�$��Center=����� $	 sBlue��$
 Value�$ PropertyChanged=��� -	   $��Center=�$
��Left=�$��1��$��4�� J� RenderTransformOrigin$ 5.357,3.409&�$��3��$	��193��$��0,0,0,50q�����  �� SelectedValue �� *Color+���� .R���  �� Orientation$ 
Horizontal=�.+��� $��20��$
��Auto��$	��5,0q�$��1q�
���   �����  �� Color �� *Color+�� ���� *Name+� $��2�� �� $��* ��� $��5* ��� $��* � �� $��* ��� $��* �.+��� -
    ��Name$ btStock��$��0��$��STOCK��$��20(�$
��10,5q��� -   $ btDelete��$��1��$��DELETE��$��20(�$
��10,5q��� -    ��Name$ 	stockList��$��1��$��15,15,15,15q�$��2��$��2��