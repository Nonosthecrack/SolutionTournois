   M S B A M L   `   `   `  ����  
AppTournoi'    !AppTournoi.Window_gestion_tournoi   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          �Name$  gestion_participant��5   	    � Title$  Ajout d'un nouveau tournoi��5   	   $	��550��6,   $	��800��69    � WindowStartupLocation$ CenterScreen=�6E    � 
ResizeMode$ NoResize=�6j   .��5      � 
������� � ColumnDefinitions 5	   
   �� 5
      $��3* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   $��0��6   $	��150��6,   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Liste��5      $��10, 10, 10, 30q�6@      AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�5      $	   HorizontalScrollBarVisibility$
	 Auto=�67   
 � ContextMenu
 5      �� 5      .@�5      m� -   5        $��Modifier��5   #   65   m� 5      -   5        $��	Supprimer��5   #   66   5         Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	IdTournoi+  5#      $ Intitule��6)    6;   �� *
Intitule+  5$      $
 Date��6)    67   �� *DateTournoi+  5%      $ Id Sport��6)    6;   �� *Sport+5'      5(      �� 5*   
   $��0��6   $��1��6"   $��10q�62    �� Orientation$ Vertical=�6>   .+�5+      �� $��Nom du tournoi��6   $
��Bold"�6-   $��14(�6?   $��0,0,0,5q�6M   �� 5,      -   5         ��Name$ 	Recherche��5,      $��Stretch=�6)   $	��Top=�6G   $��30��6_    �� TextWrapping$
 Wrap=�6k   6   5-      �� 5/   
   $��Ajouter un tournoi��6   $��1��6-   $��0��6:   $��2��6J   $
��Bold"�6^   $��20(�6p   $��10,20,10,10q�6~   $��Center=�6�   �� 51   
   $��Intitulé du tournoi��6   $��2��6.   $��0��6;   $
��Bold"�6K   $��	10,0,10,5q�6]   �� 52   
   -   5        $ 
I_intitule��52      $��2��6&   $��1��63   $��25��6C   $��	10,0,10,5q�6O   $	��2.5q�6b   �� 54   
   $��Date du tournoi��6   $��3��6*   $��0��67   $
��Bold"�6G   $��	10,0,10,5q�6Y   (  "System.Windows.Controls.DatePicker  55   
   -   5          Name$ I_Date��55      $��3��6%   $��1��62   $��30��6B   $��	10,0,10,5q�6N   �� 57   
   $��Choisir un sport��6   $��4��6+   $��0��68   $��2��6H   $
��Bold"�6\   $��	10,5,10,5q�6n   �� 58   
   -   5         ��Name$ Sports��58      $��5��6"   $��0��6/   $��2��6?   $��80��6S   $��	10,0,10,5q�6_   �� 5:   
   $��6��6   $��0��6"   $��2��62   $ 
Horizontal=�6F   $��Center=�6_   $��
10,20,10,0q�6|   .+�5;      �� -	   5         ��Name$ Ajouter��5;      $��Ajouter��6'   $	��165��69   $��40��6E   $��16(�6e   $
��Bold"�6s   ���#4682B4$��0q�6�    � Cursor$
 Hand��6�   �� 5<      -
   5        $��Annuler��5<      $	��165��6'   $��40��63   $��16(�6S   $
��Bold"�6a   ���#B22222$��0q�6�   $��10,0,0,0q�6�   $
 Hand��6�   5=      5?      5@      