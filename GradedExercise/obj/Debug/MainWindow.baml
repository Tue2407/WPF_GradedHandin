   M S B A M L   `   `   `  ����I  EGradedExercise, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GradedExerciseGradedExercise  5   	       GradedExercise.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GradedExercise     5   	     � Title$  
MainWindow��5   	   $	��450��6   $��781.176��6)   .��5	      � -   5         �Name$ 
gridPerson��5	       � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��35 �6   .+�5   
   o� $��2��6   $��0,0,257.667,99.363q�6#   $��2��6?   .@�5      m� $
��Menu��6   $��0��6%   .@�5      m� -   5        $��	Open file��5      6.   5      5      �� 5   
   -   5         ��Name$ personListBox��5      $��1��5      $��3��5      $��0��5        �� DisplayMemberPath$ ListBoxToString��5"      $��2��61   $��0,1.97,257.667,-7.97q�6E   ��5!      �� 5"   c   �� 5#   
   -   5         ��Name$ 
personName��5#      $��1��6$   $��2��64   $��2��6A   ��6U   ��  �� Path$
 Name��� 5$   
   -   5        $ personId��5$      $��1��6"   $��1��62   $��2��6?   ��6S   �� $ Id��� 5%   
   -   5        $ 	personAge��5%      $��1��6#   $��3��63   $��2��6@   ��6T   �� $	 Age��� 5&   
   -   5        $ personScore��5&      $��1��6%   $��4��65   $��2��6B   ��6V   �� $ Score��� 5'   
   -   5         ��Name$ 	statusbar��5'      $��5��6'   $��0��64   $��2��6D   .@�5(      �� -	   5        $ statusLabel��5(      5)      5*      5+      