   M S B A M L   `   `   `  ����N  JZarzadzanieUslugami, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ZarzadzanieUslugamiZarzadzanieUslugami  5   	   $    ZarzadzanieUslugami.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ZarzadzanieUslugami     5   	     � Title$  Zarzadzanie Uslugami��5   	   $	��550��6&   $	��800��63    � 
ResizeMode$ CanMinimize=�6?    � 	Resources 5
         backgroundPage �� 
StartPoint �� EndPoint � Offset � Color��%�   &	        �� 5   
   $	 0,0&�65   $	 0,1&�6F   .��5      � $	 0.0Q�6   $ #d3d3d3��6(   � 5      $	 1.0Q�6   $ #c1c1c1��6(   5      5      ��5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property � ��	 �� Value#	 [  6+   5      .��5      � 
 � ColumnDefinitions
 5   
   �� 5      $
��600* �6   �� 5      $
��200* �6    � RowDefinitions 5   
   �� 5      $
��150* �6   �� 5      $
��400* �6   .+�5!   
   �� -   5         ��Name$ NazwaUslugiTextBox��5!      $��0��60   $��0��6=   $��Center=�6M   $	��Top=�6j   $	��400��6�   $��30��6�   $��0,30,0,0q�5"      $��[Nazwa Uslugi]��6&    �� TextAlignment$ Center=�6<   $��24(�6S   $
��Bold"�6a   �� 5#   
   -   5        $ 
StanUslugi��5#      $��0��6(   $��0��65   $��Center=�6E   $��Bottom=�6b   $	��400��6}   $��30��6�   $��0,0,0,20q�5$      $��[Stan Uslugi]��6&   $ Center=�6;   $��22(�6R   $
��Bold"�6`   �� 5&   
   -   5         ��Name$ UruchomUsluge��5&      $��0��6(   $��1��65   $��Center=�6E   $	��Top=�6b   $	��140��6z   $��30��6�   $��0,30,0,0q�6�   $��Uruchomienie uslugi��5'        buttonStyle1#��[ 6K   �� 5(   
   -   5        $ ZatrzymanieUslugi��5(      $��0��6,   $��1��69   $��Center=�6I   $��Bottom=�6f   $	��140��6�   $��30��6�   $��0,0,0,20q�6�   $��Zatrzymanie uslugi��5)      #��[ 6N   �� 5+   
   -   5        $ WczytajButton��5+      $��1��6(   $��1��65   $��Center=�6E   $��Center=�6b   $	��140��6}   $��30��6�   $��0,0,0,80q�6�   $��Wczytaj wpisy��5,      #��[ 6E   �� 5-   
   -   5        $ WyczyscButton��5-      $��1��6(   $��1��65   $��Center=�6E   $��Center=�6b   $	��140��6}   $��30��6�   $��0,80,0,0q�6�   $��Wyczysc wpisy��5.      #��[ 6E   �� 50   
   -   5         ��Name$ WpisyDziennika��50      $��1��6V   $��0��6c   $��20,20,10,20q�6s   
������ $��0q�51   ,     listViewItemStyle1#��[ 6@   $��Hidden=�52      $��Hidden=�6E    �� View 53      �� 54        gridViewColumnHeaderStyle1! �� ColumnHeaderContainerStyle# [ 6   .P�55      ��  �� Width$	 300��6%    �� DisplayMemberBinding 61   �� *Tytul+��56      �� 57      .��63   Wpisy dziennika6D   59      �� 5:      $	 200��6%    61   �� *Czas+��5;      �� 5<      .��63   Czas dodania6A   5>      5?      5A      5C      5D      