   M S B A M L   `   `   `  ����  
AppTournoi'    !AppTournoi.Window_gestion_tournoi   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          �Name$  gestion_participant��5   	    � Title$, &Ajout d'un nouveau membre du personnel��5   	   $	��300��68   $	��800��6E   $	��300��6Q   $	��800��6a   $	��300��6p   $	��800��6�    � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�   .��5      � 
������� � ColumnDefinitions 5	   
   �� 5
      $��2* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��intitulé du tournoi��6   $��0��6.   $��0��6;   $
��Bold"�6K   �� 5   
   -   5         ��Name$ 
I_intitule��5      $��0��6'   $��1��64   $
��auto��6D   $��25��6Q   $��10q�6]   $��5q�6i   �� 5   
   $��Date du tournoi��6   $��1��6*   $��0��67   $
��Bold"�6G   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ I_Date��5      $��1��6%   $��1��62   $
��auto��6B   $��30��6O   $��10q�6[   �� 5   
   $��Choisir un sport��6   $��2��6,   $��0��69   $��2��6I   $
��Bold"�6]   $��
10,20,10,5q�6o   �� 5   
   -   5         ��Name$ Sports��5      $��2��6"   $��1��6/   $��2��6?   $��80��6S   $	��400��6_   �� 5   
   $��3��6   $��0��6"   $��3��62   	 �� Orientation$	 
Horizontal=�6F   $��Center=�6_   $��20q�6|   .+�5      �� -   5        $��Ajouter��5      $	��165��6'   $��40��63   $��16(�6S   $
��Bold"�6a   ���#4682B4$��0q�6�   
 � Cursor$

 Hand��6�   �� 5      -   5        $��Annuler��5      $	��165��6'   $��40��63   $��16(�6S   $
��Bold"�6a   ���#B22222$��0q�6�   $��10q�6�   $

 Hand��6�   5       5!      5"      