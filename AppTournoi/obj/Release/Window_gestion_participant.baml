   M S B A M L   `   `   `  ����   
AppTournoi+    %AppTournoi.Window_gestion_participant   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  gestion_participant�� � Title$$ Ajout d'un nouveau participant��$	��500��$	��825�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.���� $
��Auto=�$��Disabled=�.��� 
������� � ColumnDefinitions �� $
��2.5* ��� $��1.50* ��� $��1.25* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+�� $��0��$��0��$	��300��.+�&   System.Windows.Controls.DataGrid  -     Name$ Liste��$��10, 10, 10, 30q�   AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�$	   HorizontalScrollBarVisibility$
	 Auto=�
 � ContextMenu
 �� .@�m� -   $��Modifier��m� -   $��	Supprimer��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $	 Nom�� �� *Nom+  $ Prénom�� �� *Prenom+4  .System.Windows.Controls.DataGridTemplateColumn  $ Photo��   CellTemplate �� .R��� $��70��$��50������ *Photo+  $
 Sexe�� �� *Sexe+  $ Date de Naissance�� �� *DateNaissance+  $ 
Id Tournoi�� �� *	Tournoi+�� $��0��$��1��$��10q� �� Orientation$ Vertical=�.+��� $��Nom du Participant��$
��Left=�$	��Top=�$
��Bold"�$��14(��� -    ��Name$ 	Recherche��$
��Left=�$	��Top=�$��25��$	��200��$	��2.5q� �� TextWrapping$
 Wrap=��� $��Ajouter un participant��$��1��$��0��$��3��$
��Bold"�$��20(�$��10,20,20,10q�$��Center=��� $	��Nom��$��2��$��0��$
��Bold"�$��16(��� -   $ I_Nom��$��2��$��1��$
��auto��$��25��$��10q�$	��2.5q��� $��Prénom��$��3��$��0��$
��Bold"�$��16(��� -   $ I_Prenom��$��3��$��1��$
��auto��$��25��$��10q�$	��2.5q��� $
��Sexe��$��4��$��0��$
��Bold"�$��16(��� -   $ I_Sexe��$��4��$��1��$
��auto��$��25��$��10q�$	��2.5q��� $��Date de Naissance��$��5��$��0��$
��Bold"�$��16(�(  "System.Windows.Controls.DatePicker  -	     Name$ I_DateNaissance��$��5��$��1��$
��auto��$��30��$��	10,5,10,0q��� -
   $��Choisir une photo��$��5��$��2��$	��150��$��30��$��10q��� -    ��Name$ SelectedImage��$��/IconeUtilisateurs.ico��$��2��$��2��$	��100��$	��100��$��25q�$��2���� $��Choisir un tournoi��$��6��$��0��$��2��$
��Bold"�$��	0,20,10,5q�$��16(��� -    ��Name$ Tournois��$��7��$��0��$��2��$��80��$	��400���� $��8��$��0��$��3��$ 
Horizontal=�$��Center=�$��10q�.+��� -   $��Ajouter��$	��165��$��40��$��16(�$
��Bold"����#4682B4$��0q�$��10q� � Cursor$
 Hand���� -   $��Annuler��$	��165��$��40��$��16(�$
��Bold"����#B22222$��0q�$��10q�$
 Hand��