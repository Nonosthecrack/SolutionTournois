   M S B A M L   `   `   `  ����   
AppTournoi%    AppTournoi.Window_gestion_sport   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  gestion_sport�� � Title$ Ajout d'un nouveau sport��$	��600��$	��400�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� 
������� � ColumnDefinitions �� $
��2.5* ��� $��2* � � RowDefinitions �� $
��auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+�� $��0��$��0��$	��150��.+�&   System.Windows.Controls.DataGrid  -     Name$ Liste��$��10, 10, 10, 30q�   AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�$	   HorizontalScrollBarVisibility$
	 Auto=�
 � ContextMenu
 �� .@�m� -   $��Modifier��m� -   $��	Supprimer��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Intitule��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Intitule+�� $��0��$��1��$��10q� �� Orientation$ Vertical=�.+��� $��Nom du Sport��$
��Bold"�$��14(�$��0,0,0,5q��� -    ��Name$ 	Recherche��$��Stretch=�$	��Top=�$��30��$��5q� �� TextWrapping$
 Wrap=��� $��Ajouter un sport��$��1��$��0��$��2��$
��Bold"�$��20(�$��10,20,20,10q�$��Center=��� $��Intitulé du Sport:��$��2��$��0��$
��Bold"�$	��110��$��25��$��0,10,223,13.5q��� -   $ I_Sport��$��2��$��1��$
��auto��$��30��$��10q�$��5q��� $��3��$��0��$��2��$ 
Horizontal=�$��Center=�$��
10,20,10,0q�.+��� -   $��Ajouter��$	��165��$��40��$��16(�$
��Bold"����#4682B4$��0q� � Cursor$
 Hand���� -   $��Annuler��$	��165��$��40��$��16(�$
��Bold"����#B22222$��0q�$��10,0,0,0q�$
 Hand��