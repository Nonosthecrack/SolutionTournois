   M S B A M L   `   `   `  ����  
AppTournoi%    AppTournoi.Window_gestion_sport   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          �Name$  gestion_sport��5   	    � Title$ Ajout d'un nouveau sport��5   	   $	��600��6*   $	��400��66    � WindowStartupLocation$ CenterScreen=�6C    � 
ResizeMode$ NoResize=�6h   .��5      � 
������� � ColumnDefinitions 5	      �� 5
      $
��2.5* �6#   �� 5      $��2* �6#    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      � $��0��6   $��0��6    $	��150��60   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Liste��5      $��10, 10, 10, 30q�6D      AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�5      $	   HorizontalScrollBarVisibility$
	 Auto=�66   
 � ContextMenu
 5      �� 5      .@�5      m� -   5        $��Modifier��5   #   65   m� 5      -   5        $��	Supprimer��5   #   66   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Intitule��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
Intitule+5!      5"      �� 5$      $��0��6   $��1��6&   $��10q�66    �� Orientation$ Vertical=�6B   .+�5%      �� $��Nom du Sport��6   $
��Bold"�6/   $��14(�6A   $��0,0,0,5q�6O   �� 5&      -   5         ��Name$ 	Recherche��5&      $��Stretch=�6-   $	��Top=�6K   $��30��6c   $��5q�6o    �� TextWrapping$
 Wrap=�6{   6�   5'      �� 5)      $��Ajouter un sport��6   $��1��6/   $��0��6<   $��2��6L   $
��Bold"�6`   $��20(�6r   $��10,20,20,10q�6�   $��Center=�6�   �� 5+      $��Intitulé du Sport:��6   $��2��61   $��0��6>   $
��Bold"�6N   $	��110��6`   $��25��6l   $��0,10,223,13.5q�6x   �� 5,      -   5        $ I_Sport��5,      $��2��6(   $��1��65   $
��auto��6E   $��30��6R   $��10q�6^   $��5q�6j   �� 5.      $��3��6   $��0��6&   $��2��66   $ 
Horizontal=�6J   $��Center=�6c   $��
10,20,10,0q�6�   .+�5/      �� -   5         ��Name$ Ajouter��5/      $��Ajouter��6*   $	��165��6<   $��40��6H   $��16(�6h   $
��Bold"�6v   ���#4682B4$��0q�6�    � Cursor$
 Hand��6�   �� 50      -   5        $��Annuler��50      $	��165��6+   $��40��67   $��16(�6W   $
��Bold"�6e   ���#B22222$��0q�6�   $��10,0,0,0q�6�   $
 Hand��6�   51      52      53      