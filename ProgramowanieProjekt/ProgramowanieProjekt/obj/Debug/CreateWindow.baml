   M S B A M L   `   `   `  ����O  KProgramowanieProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProgramowanieProjektProgramowanieProjekt  5   	   '    !ProgramowanieProjekt.CreateWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ProgramowanieProjekt     5   	     � Title$  CreateWindow��5   	   $	��700��6   $	��700��6+   .��5	      ��  �� Padding$ 10q�6   ._�5
   
   � .+�5      �� .+�5      �  � RowDefinitions 5      �� 5      $	��150 �6(   67   .+�5      �� .+�5      �� -   5        $��
recipeName��5   ?   $��0 5 0 5q�6"   $	��150��63   $��Nazwa przepisu��6Q    �� TextAlignment$ Center=�6g   $
��Bold"�6~   $��Center=�6�   �� 5      $��0 2 0 0q�6$   $��Czas przygotowania:��65   $
��Bold"�6P   $��Center=�6b   �� 5      -   5        $
��time��5   >   $��0 0 0 2q�6"   $��60��63   $��
Czas (min)��6J   $��Center=�6\   �� 5      $��0 2 0 0q�6$   $��Koszt:��65   $
��Bold"�6C   $��Center=�6U   �� 5      -   5        $
��cost��5   >   $��0 0 0 2q�6"   $��60��63   $��Koszt (zł)��6J   $��Center=�6\   �� 5      $��0 2 0 0q�6$   $��Poziom trudności��65   $
��Bold"�6M   $��Center=�6_   �� 5      -   5        $��
difficulty��5   ?   $��0 0 0 2q�6#   $��50��64   $��Center=�6Q   .@�5      �� .��6+   1/560   �� 5      .��6+   2/560   �� 5      .��6+   3/560   �� 5      .��6+   4/560   �� 5      .��6+   5/560   5      5      5      �� 5       .+�5!      �� $��0 5 0 2q�6    $��Składniki:��61   $
��Bold"�6C   �� 5"      -   5        $��ingredients��5"   +   $	��150��6   $��Podaj składniki��6>    �� TextWrapping$
 Wrap=�6U    �� AcceptsReturn . 6i   �� 5#      $��0 5 0 2q�6    $��Przepis:��61   $
��Bold"�6A   �� 5$      -   5        $��steps��5$   +   $	��200��6   $��Podaj przepis��68   $
 Wrap=�6M    . 6a   5%      �� 5&      -   5        $��20q�5&      $��75��6%   $��30��60   .��6Q   Zapisz6Y   5'      �� 5(      -   5        $��Right=�5(      $��Bottom=�61   $��20q�6L   $	��100��6X   $��40��6d   .��6�   Menu główne6�   5)      5*      5+      