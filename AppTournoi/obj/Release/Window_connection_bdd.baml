   M S B A M L   `   `   `  ����   
AppTournoi&     AppTournoi.Window_connection_bdd   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Connexion à la BDD��$	��450��$	��800��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� 
������� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��auto � � ColumnDefinitions �� $��2* ��� $��3* �.+��� $��Adresse IP BDD��$��0��$��0��$
��Bold"�$��Center=�$��10q��� -    ��Name$ C_BDD_Ip��$��0��$��1��$��10q�$��5q�$��30��$��1q�
��������� $��Port d'écoute de la BDD��$��1��$��0��$
��Bold"�$��Center=�$��10q��� -   $ 
C_BDD_Port��$��1��$��1��$��10q�$��5q�$��30��$��1q�
��������� $��Nom d'utilisateur��$��2��$��0��$
��Bold"�$��Center=�$��10q��� -   $ C_BDD_nom_utilisateur��$��2��$��1��$��10q�$��5q�$��30��$��1q�
��������� $��Mot de passe��$��3��$��0��$
��Bold"�$��Center=�$��10q�G� -    G�Name$ 	C_BDD_mdp��$��3��$��1��$��10q�$��5q�$��30��$��1q�
��������� $��5��$��0��$��2�� �� Orientation$ 
Horizontal=�$
��Left=�$��260,70,0,20q�.+��� -   $��Enregistrer��$	��120��$��40��$��16(�$
��Bold"����#4682B4$��0q�$��10q� � Cursor$
 Hand���� -   $��Annuler��$	��120��$��40��$��16(�$
��Bold"����#B22222$��0q�$��10q�$
 Hand��