   M S B A M L   `   `   `  ����D  @MO2PartKC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MO2PartKC	MO2PartKC  5   	   "    MO2PartKC.PhoneDetailsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MO2PartKC     5   	     � Title$  PhoneDetailsWindow��5   	   $	��450��6$   $	��800��61   .��5	      � .+�5
      �� $��30,30,30,100q�6   $��Phone Details��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Make: ��6   $��Right=�5      $��30(�5      $��Center=�5      $��0��5      �� 5   
   $��Model: ��6   $��Right=�5      $��30(�5      $��Center=�5       $��1��5!      �� 5"   
   $��	Display: ��6   $��Right=�5#      $��30(�5$      $��Center=�5%      $��2��5&      �� 5'   
   $��	Storage: ��6   $��Right=�5(      $��30(�5)      $��Center=�5*      $��3��5+      �� 5,   
   $��Price: ��6   $��Right=�5-      $��30(�5.      $��Center=�5/      $��4��50      �� 51   
   -   5         ��Name$ LblMake��51      $��Make...��52      $
��Left=�53      $��30(�54      $��Center=�55      $��0��56      $��1��57      �� 58   
   -   5        $ LblModel��58      $��Model...��59      $
��Left=�5:      $��30(�5;      $��Center=�5<      $��1��5=      $��1��5>      �� 5?   
   -   5        $ 
LblDisplay��5?      $��
Display...��5@      $
��Left=�5A      $��30(�5B      $��Center=�5C      $��2��5D      $��1��5E      �� 5F   
   -   5        $ 
LblStorage��5F      $��
Storage...��5G      $
��Left=�5H      $��30(�5I      $��Center=�5J      $��3��5K      $��1��5L      �� 5M   
   -   5        $ LblPrice��5M      $��Price...��5N      $
��Left=�5O      $��30(�5P      $��Center=�5Q      $��4��5R      $��1��5S      5T   	   5U      �� 5V      -   5         ��Name$ BtnClose��5V      $��Bottom=�5W      $��Close��5X      $��30(�5Y      $��30q�5Z      5[      5\      5]      