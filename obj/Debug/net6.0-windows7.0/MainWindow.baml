   M S B A M L   `   `   `  ����M  IKomissarovPractika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KomissarovPractikaKomissarovPractika  5   	   #    KomissarovPractika.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:KomissarovPractika     5   	   $	��450��5   	   $	��800��6   
����� �  � WindowStartupLocation$  CenterScreen=�6>   .��5	      ��  �� Orientation$ Vertical=�6   .+�5
   
   �� .+�5      �� $	��100��6   �� 5      $��Black"�6   $��20(�6+   $=��7                                                  Login��69   �� 5      -   5        $
��lgn1��5   A   
�������$	��250��6)   $��30��65      placeHolder#��[  6M   
 � Tag$% Имя пользователя��6r   $��25(�6�   �� 5      -   5        $��redline1��5   U   $	��250��6   
���  ��$��5��66   $y�Hidden=�6A   6U   �� 5      $��50��6   5      �� 5   
   .+�5   
   �� $@��:                                                  Password��6   $��Black"�6V   $��20(�6i   �� 5      $ 
Horizontal=�6   .+�5      �� $	��275��6   G� 5      -   5        $
��psw1��5   I   
�������$	��250��61   $��30��6=   $! Введите пароль��6V   $y�	Collapsed=�6k   �� 5      -   5        $
��txb1��5   G   $y�Visible=�6   $	��250��6/   $��30��6;   #��[  6S   $! Введите пароль��6x   $��25(�6�   �� 5      $��20��6   �� 5      -   5        $��Passsee��5   ~   $��56��6   $��SeePass��6$   $��13(�66   $��Black"�6D   
����� �$��20��6r   6�   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��275��6   $��5��6(   �� 5      -   5        $��Redline��5   Y   $	��250��6   
���  ��$��5��6:   $y�Hidden=�6E   6Y   �� 5      $	��275��6   $��5��6(   5      �� 5      $ 
Horizontal=�6   .+�5       �� $	��200��6   �� 5!      -   5         ��Name$ 
Oshibochka��5!      $��40��60   $��25(�6<   
���  ��$
��Bold"�6[   5"      �� 5#      .+�5$      �� -   5         ��Name$	 reg��5$      $*��$Зарегистрироваться��6   $	��200��67   
����� �$��15(�6^   $
��Bold"�6l   
������ 6�   �� 5%   
   $��20��6   �� 5&      -	   5        $
 vxod��5&      $��
Войти��6#   $	��100��63   $��35��6?   
�������$��20(�6b   $��Black"�6p   
������ 6�   5'      5(      5)      5*      