   M S B A M L   `   `   `  ����   
AppTournoi'    !AppTournoi.Window_gestion_tournoi   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  gestion_participant�� � Title$  Ajout d'un nouveau tournoi��$	��550��$	��800�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� 
������� � ColumnDefinitions �� $��3* ��� $��3* � � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+�� $��0��$��0��$	��150��.+�&   System.Windows.Controls.DataGrid  -     Name$ Liste��$��10, 10, 10, 30q�   AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�$	   HorizontalScrollBarVisibility$
	 Auto=�
 � ContextMenu
 �� .@�m� -   $��Modifier��m� -   $��	Supprimer��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	IdTournoi+  $ Intitule�� �� *
Intitule+  $
 Date�� �� *DateTournoi+  $ Id Sport�� �� *Sport+�� $��0��$��1��$��10q� �� Orientation$ Vertical=�.+��� $��Nom du tournoi��$
��Bold"�$��14(�$��0,0,0,5q��� -    ��Name$ 	Recherche��$��Stretch=�$	��Top=�$��30�� �� TextWrapping$
 Wrap=��� $��Ajouter un tournoi��$��1��$��0��$��2��$
��Bold"�$��20(�$��10,20,10,10q�$��Center=��� $��Intitulé du tournoi��$��2��$��0��$
��Bold"�$��	10,0,10,5q��� -   $ 
I_intitule��$��2��$��1��$��25��$��	10,0,10,5q�$	��2.5q��� $��Date du tournoi��$��3��$��0��$
��Bold"�$��	10,0,10,5q�(  "System.Windows.Controls.DatePicker  -     Name$ I_Date��$��3��$��1��$��30��$��	10,0,10,5q��� $��Choisir un sport��$��4��$��0��$��2��$
��Bold"�$��	10,5,10,5q��� -    ��Name$ Sports��$��5��$��0��$��2��$��80��$��	10,0,10,5q��� $��6��$��0��$��2��$ 
Horizontal=�$��Center=�$��
10,20,10,0q�.+��� -	   $��Ajouter��$	��165��$��40��$��16(�$
��Bold"����#4682B4$��0q� � Cursor$
 Hand���� -
   $��Annuler��$	��165��$��40��$��16(�$
��Bold"����#B22222$��0q�$��10,0,0,0q�$
 Hand��