   M S B A M L   `   `   `  ����?  ;Jamb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:JambJamb  5   	       Jamb.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Jamb     5   	   $��16(�5        � Title$
  Yamb��5   	   $
��Auto��6   $	��400��6$   ���#2a2a2a$(��"Segoe UI Variable Display Semibold)�6E   .��5      �  � ColumnDefinitions 5      �� 5      $��20 �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $��20 �6#    � RowDefinitions 5      �� 5      $��25 �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5       $
��auto �6    �� 5"      $
��auto �6    �� 5#      $
��auto �6    �� 5%      $
��auto �6    �� 5'      $
��auto �6    �� 5(      $
��auto �6    �� 5)      $
��auto �6    �� 5*      $
��auto �6    �� 5+      $
��auto �6    �� 5,      $
��auto �6    �� 5-      $
��auto �6    �� 5/      $
��auto �6    �� 50      $
��auto �6    �� 52      $��20 �6   .+�56   
   �� $��1��6   $��2��6$   $��1��61   $��Center=�6:   $��Center=�6W   �� 57   
   $��1��6   $��3��6$   $��2��61   $��Center=�6:   $��Center=�6W   �� 58   
   $��1��6   $��4��6$   $��3��61   $��Center=�6:   $��Center=�6W   �� 59   
   $��1��6   $��5��6$   $��4��61   $��Center=�6:   $��Center=�6W   �� 5:   
   $��1��6   $��6��6$   $��5��61   $��Center=�6:   $��Center=�6W   �� 5;   
   $��1��6   $��7��6$   $��6��61   $��Center=�6:   $��Center=�6W   �� 5<   
   $��1��6   $��8��6$   $��Score��61   $��Center=�6>   $��Center=�6[   �� 5=   
   $��1��6   $��9��6$   $	��Max��61   $��Center=�6<   $��Center=�6Y   �� 5>   
   $��1��6   $��10��6$   $	��Min��62   $��Center=�6=   $��Center=�6Z   �� 5?   
   $��1��6   $��11��6$   $��Score��62   $��Center=�6?   $��Center=�6\   �� 5@   
   $��1��6   $��12��6$   $��1 Pair��62   $��Center=�6@   $��Center=�6]   �� 5A   
   $��1��6   $��13��6$   $��3 of a Kind��62   $��Center=�6E   $��Center=�6b   �� 5B   
   $��1��6   $��14��6$   $��Straight��62   $��Center=�6B   $��Center=�6_   �� 5C   
   $��1��6   $��15��6$   $
��Full��62   $��Center=�6>   $��Center=�6[   �� 5D   
   $��1��6   $��16��6$   $��Poker��62   $��Center=�6?   $��Center=�6\   �� 5E   
   $��1��6   $��17��6$   $
��Yamb��62   $��Center=�6>   $��Center=�6[   �� 5F   
   $��1��6   $��18��6$   $��Score��62   $��Center=�6?   $��Center=�6\   �� 5J   
   $��2��6   $��0��6    $��/up_sybol.png��6-   �� 5K   
   -   5         ��Name$
 up_1��5K      $��2��6   $��2��6/   $�� ��6<   6G   �� 5L   
   -   5        $
 up_2��5L      $��2��6   $��3��6/   $�� ��6<   6G   �� 5M   
   -   5        $
 up_3��5M      $��2��6   $��4��6/   $�� ��6<   6G   �� 5N   
   -   5        $
 up_4��5N      $��2��6   $��5��6/   $�� ��6<   6G   �� 5O   
   -   5        $
 up_5��5O      $��2��6   $��6��6/   $�� ��6<   6G   �� 5P   
   -   5        $
 up_6��5P      $��2��6   $��7��6/   $�� ��6<   6G   �� 5Q   
   -   5         ��Name$ up_single_score��5Q      $	��2  ��6-   $��8��6?   $�� ��6L   �� 5R   
   -   5        $ up_max��5R      $��2��6!   $��9��61   $�� ��6>   6I   �� 5S   
   -	   5        $ up_min��5S      $��2��6!   $��10��61   $�� ��6?   6J   �� 5T   
   -
   5        $ up_min_max_score��5T      $��2��6.   $��11��6>   $�� ��6L   �� 5U   
   -   5        $ up_1Pair��5U      $��2��6#   $��12��63   $�� ��6A   6L   �� 5V   
   -   5        $ up_3OfK��5V      $��2��6"   $��13��62   $�� ��6@   6K   �� 5W   
   -   5        $ up_str��5W      $��2��6!   $��14��61   $�� ��6?   6J   �� 5X   
   -   5        $ up_full��5X      $��2��6"   $��15��62   $�� ��6@   6K   �� 5Y   
   -   5        $ up_pok��5Y      $��2��6!   $��16��61   $�� ��6?   6J   �� 5Z   
   -   5        $ up_yamb��5Z      $��2��6"   $��17��62   $�� ��6@   6K   �� 5[   
   -   5        $ up_total_score��5[      $��2��6,   $��18��6<   $�� ��6J   �� 5a   
   $��3��6   $��0��6    $��/do_sybol.png��6-   �� 5b   
   -   5        $
 do_1��5b      $��3��6   $��2��6/   $�� ��6<   6G   �� 5c   
   -   5        $
 do_2��5c      $��3��6   $��3��6/   $�� ��6<   6G   �� 5d   
   -   5        $
 do_3��5d      $��3��6   $��4��6/   $�� ��6<   6G   �� 5e   
   -   5        $
 do_4��5e      $��3��6   $��5��6/   $�� ��6<   6G   �� 5f   
   -   5        $
 do_5��5f      $��3��6   $��6��6/   $�� ��6<   6G   �� 5g   
   -   5        $
 do_6��5g      $��3��6   $��7��6/   $�� ��6<   6G   �� 5h   
   -   5        $ do_single_score��5h      $��3��6-   $��8��6=   $�� ��6J   �� 5i   
   -   5        $ do_max��5i      $��3��6!   $��9��61   $�� ��6>   6I   �� 5j   
   -   5        $ do_min��5j      $��3��6!   $��10��61   $�� ��6?   6J   �� 5k   
   -   5        $ do_min_max_score��5k      $��3��6.   $��11��6>   $�� ��6L   �� 5l   
   -   5        $ do_1Pair��5l      $��3��6#   $��12��63   $�� ��6A   6L   �� 5m   
   -   5        $ do_3OfK��5m      $��3��6"   $��13��62   $�� ��6@   6K   �� 5n   
   -   5        $ do_str��5n      $��3��6!   $��14��61   $�� ��6?   6J   �� 5o   
   -   5        $ do_full��5o      $��3��6"   $��15��62   $�� ��6@   6K   �� 5p   
   -    5        $ do_pok��5p      $��3��6!   $��16��61   $�� ��6?   6J   �� 5q   
   -!   5        $ do_yamb��5q      $��3��6"   $��17��62   $�� ��6@   6K   �� 5r   
   -"   5        $ do_total_score��5r      $��3��6,   $��18��6<   $�� ��6J   �� 5v   
   $��4��6   $��0��6    $��/fr_sybol.png��6-   �� 5w   
   -#   5        $
 fr_1��5w      $��4��6   $��2��6/   $�� ��6<   6G   �� 5x   
   -$   5        $
 fr_2��5x      $��4��6   $��3��6/   $�� ��6<   6G   �� 5y   
   -%   5        $
 fr_3��5y      $��4��6   $��4��6/   $�� ��6<   6G   �� 5z   
   -&   5        $
 fr_4��5z      $��4��6   $��5��6/   $�� ��6<   6G   �� 5{   
   -'   5        $
 fr_5��5{      $��4��6   $��6��6/   $�� ��6<   6G   �� 5|   
   -(   5        $
 fr_6��5|      $��4��6   $��7��6/   $�� ��6<   6G   �� 5}   
   -)   5        $ fr_single_score��5}      $��4��6-   $��8��6=   $�� ��6J   �� 5~   
   -*   5        $ fr_max��5~      $��4��6!   $��9��61   $�� ��6>   6I   �� 5   
   -+   5        $ fr_min��5      $��4��6!   $��10��61   $�� ��6?   6J   �� 5�   
   -,   5        $ fr_min_max_score��5�      $��4��6.   $��11��6>   $�� ��6L   �� 5�   
   --   5        $ fr_1Pair��5�      $��4��6#   $��12��63   $�� ��6A   6L   �� 5�   
   -.   5        $ fr_3OfK��5�      $��4��6"   $��13��62   $�� ��6@   6K   �� 5�   
   -/   5        $ fr_str��5�      $��4��6!   $��14��61   $�� ��6?   6J   �� 5�   
   -0   5        $ fr_full��5�      $��4��6"   $��15��62   $�� ��6@   6K   �� 5�   
   -1   5        $ fr_pok��5�      $��4��6!   $��16��61   $�� ��6?   6J   �� 5�   
   -2   5        $ fr_yamb��5�      $��4��6"   $��17��62   $�� ��6@   6K   �� 5�   
   -3   5        $ fr_total_score��5�      $��4��6,   $��18��6<   $�� ��6J   �� 5�   
   -4   5        $ single_score��5�      $��5��6*   $��8��6:   $�� ��6G   �� 5�   
   -5   5        $ min_max_score��5�      $��5��6+   $��11��6;   $�� ��6I   �� 5�   
   -6   5        $ total_score��5�      $��5��6)   $��18��69   $�� ��6G   �� 5�   
   -7   5        $ dice1��5�   0   $��1��6   $��19��6!   $��60��6R   $��60��6]   .��5�      �� $��
/dice1.png��6   $��55��6(   $��55��63   $��Stretch=�6?   $��Stretch=�6]   5�      �� 5�   
   -8   5        $ dice2��5�   /   $��2��6   $��19��6!   $��5q�6Q   $��60��6\   $��60��6g   .��5�      �� $��
/dice2.png��6   $��55��6(   $��Stretch=�63   $��Stretch=�6Q   5�      �� 5�   
   -9   5        $ dice3��5�   0   $��3��6   $��19��6"   $��5q�6R   $��60��6]   $��60��6h   .��5�      �� $��
/dice3.png��6   $��55��6(   $��Stretch=�63   $��Stretch=�6Q   5�      �� 5�   
   -:   5        $ dice4��5�   /   $��4��6   $��19��6!   $��5q�6Q   $��60��6\   $��60��6g   .��5�      �� $��
/dice4.png��6   $��55��6(   $��Stretch=�63   $��Stretch=�6Q   5�      �� 5�   
   -;   5        $ dice5��5�   /   $��5��6   $��19��6!   $��5q�6Q   $��60��6\   $��60��6g   .��5�      �� $��
/dice5.png��6   $��55��6(   $��Stretch=�63   $��Stretch=�6Q   5�      �� 5�   
   -<   5        $ 
rollButton��5�   /   $��3��6   $��20��6!   $
��Roll��6C   $��10q�6e   5�      5�      