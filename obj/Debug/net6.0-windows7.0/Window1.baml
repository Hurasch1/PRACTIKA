   M S B A M L   `   `   `  ����M  IKomissarovPractika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KomissarovPractikaKomissarovPractika  5   	        KomissarovPractika.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:KomissarovPractika     5   	   -   5        $	��450��5   	   $	��800��6   
����� �  � WindowStartupLocation$  CenterScreen=�6V   .��5	      �� .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��550��6   $��60��6$   �� 5      -   5         ��Name$
 back��5      $��
Назад��6#   $��20(�63   $��Black"�6A   $	��150��6T   $��40��6`   
�������
������ 6�   5      �� 5   
   $��Black"�6   $��20(�6'   $=��7                                                  Login��65   �� 5   
   -   5        $	��Lgn��5   =   
�������$	��250��6%   $��30��61   $��15(�6H      placeHolder#��[  6V   
 � Tag$4 .Введите имя пользователя��6{   �� 5   
   .+�5      �� $��10��6   �� 5   	   $��Black"�6   $��20(�6&   $=��7                                                  Email��64   �� 5      -   5        $	��Eml��5   A   
�������$	��250��6)   $��30��65   $��15(�6L   #��[  6Z   $ Введите email��6   �� 5      $ 
Horizontal=�6   .+�5      �� $	��265��6   $��5��6(   �� 5      -   5        $��redline1��5   X   $	��250��6   
���  ��$y�Hidden=�69   $��5��6M   6X   �� 5      $	��275��6   $��5��6(   5      �� 5      $��Black"�6   $��20(�6+   $@��:                                                  Password��69   �� 5      -   5        $	��Psw��5   A   
�������$	��250��6)   $��30��65   $��15(�6L   #��[  6Z   $! Введите пароль��6   �� 5      $ 
Horizontal=�6   .+�5      �� $	��265��6   $��5��6(   �� 5      -   5        $��redline2��5   X   $	��250��6   
���  ��$y�Hidden=�69   $��5��6M   6X   �� 5      $	��275��6   $��5��6(   5      �� 5       $��Black"�6   $��20(�6+   $F��@                                                  Retry password��69   �� 5!      -   5        $
��Rpsw��5!   A   
�������$	��250��6)   $��30��65   $��15(�6M   #��[  6[   $% Повторите пароль��6�   �� 5"      $ 
Horizontal=�6   .+�5#      �� $	��265��6   $��5��6(   �� 5$      -	   5        $��redline3��5$   X   $	��250��6   
���  ��$y�Hidden=�69   $��5��6M   6X   �� 5%      $	��275��6   $��5��6(   5&      �� 5'      $ 
Horizontal=�6   .+�5(      �� $��40��6   $	��185��6(   �� 5)      -
   5        $��Vivod2��5)   4   $��40��6   $	��450��6(   
���  ��$��20(�6S   �� 5*      $��40��6   $	��185��6(   5+      �� 5,   
   -   5        $ Registr��5,      $*��$Зарегистрироваться��6"   $	��200��6?   $��40��6K   
������ $��20(�6q   $��DemiBold"�6   
�������6�   5.      5/      51      