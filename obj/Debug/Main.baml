   M S B A M L   `   `   `  ����F  BWPF_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_ProjectWPF_Project  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L5clr-namespace:System.Diagnostics;assembly=WindowsBaseSystem.Diagnostics 5          WPF_Project.Main   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WPF_Project     5      Fdiag5clr-namespace:System.Diagnostics;assembly=WindowsBase     5      -   5          N� 
Background
  ����� � DataContext 5        WPF_Project.PwdViewModel  5   
    � 	Resources 5        WPF_Project.ViewConverter   viewConverter  MenuItem �� 
TargetType �� Property �� Value  DirItem  	OtherItem#  WPF_Project.EditableConverter  editableConverter��%6  &	        &	      &	 [     &	 �     &	 �       5   
   6   �� 5   
   " m�6!   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6    .�5      ��  � ��$
 Bold"�6+   5      �� 5   
   " ��6"   .�5      ��  � ��$ Italic$�6*   5        5   
   6"   5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   .+�5    
   ]� $��0��6   $��Stretch=�6!   .+�5!      o� $	��Top=�6   $��Right=�6(   .@�5"      m� #��[ 6   $��Password Generator��6=   m� 5#      -   5        #��[ 5#      $��Log out��6=   6N   m� 5$      #��[ 6   $
��Save��6=    m� Command 6K   �� *
SaveData+5%      5&      � 5'   
   $��1��6    � ColumnDefinitions 5(      �� 5)      $��1* �6#   �� 5*      $��10 �6#   �� 5+      $��4* �6#   .+�5-      R� -   5        	 R�Name$	 TreeView��5-   '   $��0��6   ��69   �� *Items+ 50        DefaultContextMenu  DirContextMenu  PwdContextMenu  ImgContextMenu 	 NormalOtherTemplate
 �� Orientation �� Mode 
 NormalDirTemplate  EditableTemplate �� DataType   WPF_Project.DirItem �� ItemsSource �� Path �� Triggers �� Value �� Binding `� 	Converter �� RelativeSource �� AncestorType   WPF_Project.PwdItem   WPF_Project.ImgItem��%�  &	       &	     &	 �    &	 �    &		     7  &	
     7  &	 �    (��     5_   /   *, +)7 
 7  7  (�� �    5v   /   *, +)7 	 7  7  (�� C	    5�   /   *, +)7 	 7  7  �� 51      .@�52      m� $��Add Directory��6#    6:   �� *DirAddCommand+m� 53      $��Add file��6#   .@�54      m� $��	Passwords��6'    6:   �� *PwdAddCommand+m� 55      $��Image��6'    66   �� *ImgAddCommand+56      57      �� 58      .@�59      m� $��New Directory��6#   {�.  6:   �� 5:      m� 5;      $��Add Directory��6#    6:   �� *DirAddInsideCommand+m� 5<      $��	Add Files��6#   .@�5=      m� $��	Passwords��6'    6:   �� *PwdAddInsideCommand+m� 5>      $��Image��6'    66   �� *ImgAddInsideCommand+5?      �� 5@      m� 5A      -   5        $��Rename��5A   #   63   m� 5B      -   5        $��Delete��5B   #   63   5C      �� 5D      .@�5E      m� $��New Password��6#   {�.  69   �� 5F      m� 5G      -   5        $��Rename��5G   #   63   m� 5H      -   5        $��Delete��5H   #   63   5I      �� 5J      .@�5K      m� $��	New Image��6#   {�.  66   �� 5L      m� 5M      -   5        $��Rename��5M   #   63   m� 5N      -	   5        $��Delete��5N   #   63   5O      �� 5P      .R�5Q      �� $
 
Horizontal=�6%   .+�5R      �� 8��  ��6(   �� *Header+$ TwoWay=�6M   5S      5T      �� 5U      .R�5V      �� $
 
Horizontal=�6%   .+�5W      �� 8��  ��6(   �� *Header+$ TwoWay=�6M   5X      5Y      �� 5Z      .R�5[      �� $
 
Horizontal=�6%   .+�5\      �� ��6'   �� *Header+$ TwoWay=�5]      5^      �� 5_      "  6/    5`   /   �� $ Items�.R�5a      �� ��6+   �� ��5b      �� 5c   "   " ��6(   .�5d   &   ��  � ��8   5e   -    5f   &   �� 5g   *    True66    5h   .   `� 5i   2   8  .1�5j   6   �� $ 
IsSelected�6>    5k   >   �� $ TreeViewItemL��� 5l   6   $ 
IsEditable�6>   5m   3   .a�5o   .   ��  � ��8  6P   5p   +   5r   #   5t      5u      �� 5v      "  6/   .R�5w      �� ��6+   �� ��5x      �� 5y   "   " ��6(   .�5z   &   ��  � ��8   5{   -    5|   &   �� 5}   *    True66    5~   .   `� 5   2   8  .1�5�   6   �� $ 
IsSelected�6>    5�   >   �� $ TreeViewItemL��� 5�   6   $ 
IsEditable�6>   5�   3   .a�5�   .   ��  � ��8  6P   5�   +   5�   #   5�      5�      �� 5�      "  6/   .R�5�      �� ��6+   �� ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��8   5�   -    5�   &   �� 5�   *    True66    5�   .   `� 5�   2   8  .1�5�   6   �� $ 
IsSelected�6>    5�   >   �� $ TreeViewItemL��� 5�   6   $ 
IsEditable�6>   5�   3   .a�5�   .   ��  � ��8  6P   5�   +   5�   #   5�      5�      5�      5�      �� 5�      $��1��6   ]� 5�      $��2��6   .+�5�       � -
   5          �Name$ _NavigationFrame��5�        � NavigationUIVisibility$ Hidden=�62   $��Stretch=�5�      $��Stretch=�66     � Source 5�      ��  �� ElementName$ TreeView��$ SelectedItem�$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� 	Converter# [  5�   6   5�      5�      5�      5�      