   M S B A M L   `   `   `  ����E  AAppTournoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AppTournoi
AppTournoi  5   	   ,    &AppTournoi.Window_gestion_gestionnaire   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AppTournoi     5   	     � Title$!  Window_gestion_gestionnaire��5   	   $	��375��6-   $	��600��6:    � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ NoResize=�6k   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   $��0��6   $	��150��6,   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Liste��5      $��10, 10, 10, 30q�6@      AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�5      $   HorizontalScrollBarVisibility$
 Auto=�6<   	 � ContextMenu	 5      �� 5      .@�5      m� -   5        $��Modifier��5   #   65   m� 5      -   5        $��	Supprimer��5   #   66   5      
   Columns
 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ login��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Login+5$      5%      �� 5'   
   $��0��6   $��1��6"   $��10q�62    �� Orientation$ Vertical=�6>   .+�5(      �� $��Nom du gestionnaire��6   $
��Bold"�62   $��14(�6D   �� 5)      -   5         ��Name$ 	Recherche��5)      $��Stretch=�6)   $	��Top=�6G   $��30��6_    �� TextWrapping$
 Wrap=�6k   6   5*      �� 5,   
   $��Ajouter un Gestionnaire��6   $��1��62   $��0��6?   $��2��6O   $
��Bold"�6c   $��20(�6u   $��10,20,10,10q�6�   $��Center=�6�   �� 5.   
   $��Login du gestionnaire��6   $��2��60   $��0��6=   $
��Bold"�6M   $��	10,0,10,5q�6_   �� 5/   
   -   5        $ I_login��5/      $��2��6#   $��1��60   $��25��6@   $��	10,0,10,5q�6L   $	��2.5q�6_   �� 51   
   $"��Mot de passe du gestionnaire��6   $��3��67   $��0��6D   $
��Bold"�6T   $��	10,0,10,5q�6f   G� 52   
   -   5         G�Name$ I_mdp��52      $��3��6%   $��1��62   $��25��6B   $��	10,0,10,5q�6N   $	��2.5q�6a   �� 54   
   $��4��6   $��0��6"   $��2��62   $ 
Horizontal=�6F   $��Center=�6_   $��
10,20,10,0q�6|   .+�55      �� -   5         ��Name$ Ajouter��55      $��Ajouter��6&   $	��165��68   $��40��6D   $��16(�6d   $
��Bold"�6r   ���#4682B4$��0q�6�    � Cursor$
 Hand��6�   �� 56      -   5        $��Annuler��56      $	��165��6'   $��40��63   $��16(�6S   $
��Bold"�6a   ���#B22222$��0q�6�   $��10,0,0,0q�6�   $
 Hand��6�   57      58      59      