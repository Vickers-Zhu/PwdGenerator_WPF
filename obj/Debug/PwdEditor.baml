   M S B A M L   `   `   `  ����F  BWPF_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_ProjectWPF_Project  5          WPF_Project.PwdEditor   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WPF_Project     5        N� Title$  	PwdEditor��5	       � DataContext 5
      #  WPF_Project.PwdViewerViewMode  5   
    � 	Resources 5      '  !WPF_Project.StrenthValueConverter   strenthValueConverter#  WPF_Project.PwdColorConverter  pwdColorConverter%  WPF_Project.ResolutionConverter  resolutionConveter&   WPF_Project.ImageFormatConverter  imageFormatConveter 	 Label �� 
TargetType �� Property �� Value  FooterBtnStyle��%g  &	        &	      &	 &     &	 9     &	 L     &	 �       5   
   6&     5   
   6"     5   
   6$     5   
   6%   �� 5   
   " ��6   .�5      ��  � ��$ Right=�64   �� 5       � ��$ Center=�62   5      �� 5   
   " ��6'   .�5      ��  � ��$ 20��6'   �� 5       � ��$ 30��6&   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6    � RowDefinitions 5    
   �� 5!      $	��100 �6   �� 5"      $��30 �6   �� 5#      $��30 �6   �� 5$      $��30 �6   �� 5%      $��30 �6   �� 5&      $��30 �6   �� 5'      $��* �6   �� 5(      $��30 �6   .+�5*   
   �� $
��Icon��6   #��[ 6    $��0��6?   $��0��6O   �� 5+   
   $
��Name��6   #��[ 6    $��0��6?   $��1��6O   �� 5,   
   $��Email��6   #��[ 6!   $��0��6@   $��2��6P   �� 5-   
   $��Login��6   #��[ 6!   $��0��6@   $��3��6P   �� 5.   
   $��Password��6   #��[ 6$   $��0��6C   $��4��6S   �� 5/   
   $��Website��6   #��[ 6#   $��0��6B   $��5��6R   �� 50   
   $��Notes��6   #��[ 6!   $��0��6@   $��6��6P   ]� 51   
   $��1��6   $��0��6$   .+�52      �� $��1��64   $��0��6D   $��Center=�6Q   ��6   �� *
SelectIcon+.��53      �� .+�54      �� -   5         ��Name$ ImageBox��54      $
��Fill=�6^   $	��100��6m   $	��100��6y   ��6.   �� 	 �� Path$	 
CacheImage�
 �� Mode$
 TwoWay=�6y   �� 55      $��Select��6    56      57      �� 58       �� Orientation$ Vertical=�6   $��Right=�60   $��Right=�6L   .+�59      �� ��6   ��  �� ElementName$ ImageBox��$	 Source� �� 	Converter# [ $
 OneWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5;      ��6   �� *DPI+�� 5<      ��6   �� $ ImageBox��$	 Source�# [ $
 OneWay=�$ PropertyChanged=�5>      5?      �� 5A   
   -   5         ��Name$ NameBox��5A      $��1��6L   $��1��6\   $��5 5 5 5q�5B      ��5A   #   �� $
	 Name�$
 OneTime=�5B      �� 5C   
   -   5        $ EmailBox��5C      $��1��6N   $��2��6^   $��Consolas)�5D      $��5 5 5 5q�5E      ��5C   $   �� $	 Email�$
 OneTime=�5E      �� 5F   
   -   5        $ LoginBox��5F      $��1��6N   $��3��6^   $��Consolas)�5G      $��5 5 5 5q�5H      ��5F   $   �� $	 Login�$
 OneTime=�5H      �� 5I   
   $��1��6   $��4��6%   .+�5J      �� -   5        $ PwdInput��5J      $��Consolas)�5K      $��5 5 5 5q�5L      ��5J   (   �� $	 Password�$
 OneTime=�5L      � 5M      $��15��6    � Minimum$ 0Q�6&    � Maximum$ 5Q�62    � Value 5N      �� $ PwdInput��$
	 Text�# [  ��5O      �� $ PwdInput��$
	 Text�# [ 5P      �� 5Q   
   -   5        $ WebBox��5Q      $��1��6N   $��5��6^   $��5 5 5 5q�5R      ��5Q   "   �� $	 Website�$
 OneTime=�5R      �� 5S   
   -   5        $ NotesBox��5S      $��1��6N   $��6��6^   $��5 5 5 5q�5T      ��5S   $   �� $	 Notes�$
 OneTime=�5T      �� 5U   
   $��7��6   
�������$��1��69   $��Stretch=�6I   $ 
Horizontal=�5V      .+�5W      �� -   5        #��[ 5W      $��Apply��6=   $��Right=�5X   -   �� 5Y      -	   5        #��[ 5Y      $��Cancle��6=   $��Right=�5Z   *   5[      5\      5]      