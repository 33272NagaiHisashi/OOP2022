   M S B A M L   `   `   `  ���� L  HSampleApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SampleApplicationSampleApplication  "    SampleApplication.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:SampleApplication       � Title$  
MainWindow��$	��300��$	��300��.���  � ColumnDefinitions �� $
��AUTO ��� $��* ��� $	��100 � � RowDefinitions �� $
��AUTO ��� $
��AUTO ��� $
��AUTO ��� $
��AUTO ��� $��* �.+��� $��2��$��Center=�$��項目���� $��2��$��	設定値���� $��1��$��
ON/OFF(_O)�� �� Target ��  �� ElementName$ cb�� �� Mode$ OneWay=��� -    ��Name$ cb��$��1��$��1��$��チェックしたらON��$��Center=��� -    ��Name$ checkBoxTextBlock��$��1��$��2��$��Center=��� $��2��$��色(_C)�� �� $ rbRed��$ OneWay=��� $��2��$��1��.+�	� -    	�Name$ rbRed��	 	� 	GroupName$	 Color��$	��赤��	� -   $ rbYellow��$	 Color��$	��黄��	� -   $ rbBlue��$	 Color��$	��青��$��0,0,4,0q��� -   $ tbColor��$��2��$��2���� $��3��$��
季節(_S)�� �� $ cbSeason��$ OneWay=��� -   
 ��Name$
 cbSeason��$��3��$��1��.@��� $	��春���� $	��夏���� $	��秋���� $	��冬���� -   $ tblockSeason��$��3��$��2��