   M S B A M L   `   `   `  ����E  AAppTournoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AppTournoi
AppTournoi  5   	   *    $AppTournoi.Window_liste_participants   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AppTournoi     5   	     � Title$  Liste des participants��5   	   $	��450��6(   $	��800��65   $	��450��6A   $	��800��6Q    � WindowStartupLocation$ CenterScreen=�6`   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $
��1.5* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Liste��5      $��0��6<   $��0��6I   $��10q�6Y      AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�5      $   HorizontalScrollBarVisibility$ Disabled=�66      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+  5      $		 Nom��6%   
 62   �� *Nom+  5      $	 Prénom��6%   
 65   �� *Prenom+4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Photo��6)      CellTemplate 5      �� 5      .R�5      �� $��70��6=   $��50��6H   ��6$   �� *Photo+6H   5      5        5      $
	 Sexe��6%   
 63   �� *Sexe+  5       $	 Date de Naissance��6%   
 6@   �� *DateNaissance+  5!      $	 
Id Tournoi��6%   
 69   �� *	Tournoi+5#      �� 5%   
   $��0��6   $��1��6"   $��10q�62    �� Orientation$ Vertical=�6>   .+�5&      �� $��Nom du Participant��6   $
��Left=�61   $	��Top=�6L   $
��Bold"�6d   $��16(�6v   �� 5'      -   5         ��Name$ 	Recherche��5'      $
��Left=�6)   $	��Top=�6D   $	��225��6\   $��25��6h   $��	10,0,10,0q�6t    �� TextWrapping$
 Wrap=�6�   6�   5(      5)      5*      