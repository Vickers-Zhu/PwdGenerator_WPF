   M S B A M L   `   `   `  ����F  BWPF_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_ProjectWPF_Project  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5          WPF_Project.Pwd   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WPF_Project     5      ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5      -   5          N� Title$	  Pwd��5
      $	��150��5      $	��300��6    � 	Resources 5      #  WPF_Project.PwdColorConverter   pwdColorConverter&   WPF_Project.StrenthTextConverter  strenthTextConverter&    WPF_Project.FirstLetterConverter  FirstLetterConv(  "WPF_Project.ReverseBoolenConverter  reverseBoolenConverter  PwdsView �� Source �� Path �� Mode �� UpdateSourceTrigger �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription	   PropertyName
   	Converter  pwdItem �� DataType   WPF_Project.Pwd � ColumnDefinitions � RowDefinitions �� Orientation �� TextAlignment �� 	Converter  GroupingHeader��%  &	        &	      &	 &     &	 9     &	 L     7  &	     7  7   &	 Q      5   
   6"     5   
   6%     5   
   6%     5   
   6'   �� 5   
    5      �� $ 	Passwords�$ OneWay=�$ PropertyChanged=� 5        5      $
 Name��61    5        5      $
	 Name��6+   8
   6?   5      �� 5   
   "  6'   .R�5      �� $��2q�6   
�������._�5       �  5!      �� 5"      $	��100 �6+   �� 5#      $��* �6+   .+�5%      �� $��0��6l   ��6   �� $
 Icon�$ OneTime=�$ PropertyChanged=�6l   � 5&      $��1��6    5'      �� 5(      $��30 �6,   �� 5)      $��* �6,   .+�5+      � $��0��6   .+�5,      �� $
��Left=�6h   ��6(   �� $
 Name�$ PropertyChanged=�6h   5-      �� 5.      $��1��6%   $ 
Horizontal=�62   .+�5/      �� ��6(   �� $ Login�$ PropertyChanged=��� 50      $��	         ��6(   �� 51      $��Right=�55   !   $ Right=�6=   ��51   (   �� $ Password�8   $ PropertyChanged=���53   !   �� $ Password�8  $ PropertyChanged=�55   =   56      57      58      59      5:      �� 5;   
   .R�5<      �� 
�������
���������6   �� $
 Name�$ PropertyChanged=�6j   5=      5>       � DataContext 5?      #  WPF_Project.PwdEditorViewMode  5@   
   .��5B      �  5C   
   �� 5D      $��1* �6   �� 5E      $��3* �6   .+�5G   
   � $��0��6    5H      �� 5I      $��30 �6    �� 5J      $��* �6    .+�5L      �� $ 
Horizontal=�6   .+�5M      �� -   5         ��Name$ 	SearchBox��5M      $	��200��6-   $�� ��69   6A   �� 5N      -   5        $	��Add��5N      ��6'   �� *OnePwdAddCommand+{�5O      �� *	IsEditing+# [ $ OneWay=�$ PropertyChanged=�5Q      �� 5R      -   5         ��Name$ PwdList��5R      $��1��6'   $ �� IsSynchronizedWithCurrentItem$ FalseY�5S      #��[ 5U      ��5R   4   ��  �� Source# [  �� SelectedItem 5V      �� *SelectedPwd+$ TwoWay=�$ PropertyChanged=� �� 
GroupStyle 5X      (	  "System.Windows.Controls.GroupStyle	  5Y       	  HeaderTemplate# [ 5Z      5\      5]      �� 5^   
   $��0��6   $y�Visible=�6'    K� ZIndex$ 1��6<   � 5_   
   $��2��6    5`      �� 5a      $��* �6    �� 5b      $��50 �6    .+�5d       � -   5          �Name$ EditorFrame��5d      $��0��6)   5e      5f      5g      5h      