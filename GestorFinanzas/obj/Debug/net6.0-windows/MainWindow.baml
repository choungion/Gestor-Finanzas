   M S B A M L   `   `   `  ����I  EGestorFinanzas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GestorFinanzasGestorFinanzas  5   	       GestorFinanzas.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GestorFinanzas     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�5	   	   .��5
      � .+�5   
   o� -   5        $��MenuPrincipal��5      $��46��6   $��46��60   $��	10,10,0,0q�6;   $
��Left=�6N   $	��Top=�6i   $��2q�6�   .@�5      m� $�� ��6   $��45��6!   $��45��6,   $��2,2,2,2q�68    m� Icon 5      �� 5      $��/Hamburger_icon.svg.png��6   $��35��6=   $��0,-15,-19,-14q�6H   .@�5      m� -   5         m�Name$ MenuItemTransacciones��5      $��Transacciones��6:    m� IsCheckable$ False��6Q   m� 5      -   5        $ MenuItemReportes��5      $��Reportes��65   $ False��6G   
 � Tag$] WAcá podrá ver el reporte anual de sus movimientos financieros y el desglose del mismo��6�   5      5      o� 5   
   -   5        $��MenuAgregar��5      $��46��6   $��46��6.   $��	10,10,0,0q�69   $��Right=�6L   $��Bottom=�6h   $��2q�6�   .@�5      m� $�� ��6   $��45��6!   $��45��6,    5      �� 5      $��/Add Icon.png��6   $��35��63   $��0,-15,-19,-14q�6>   .@�5      m� -   5        $ MenuItemIngresos��5      $��Ingresos��65   $ False��6G   6[   m� 5      -   5        $ MenuItemGastos��5      $��Gastos��63   $ False��6C   6W   m� 5      -   5        $ MenuItemTransferir��5      $��
Transferir��67   $ False��6K   6_   5      5      �� 5   
   $��Ingresos��6   $
��Left=�6#   $��338,126,0,0q�6>   $	��Top=�6S   $��16(�6k   �� 5   
   $��Gastos��6   $
��Left=�6!   $��340,198,0,0q�6<   $	��Top=�6Q   $��16(�6i   �� 5    
   -	   5         ��Name$ LabelIngresos��5       $��₡ 0��6'   $
��Left=�65   $��338,162,0,0q�6P   $	��Top=�6e   $��14(�6}   
��� � �6�   �� 5!   
   -
   5        $ LabelGastos��5!      $��₡ 0��6%   $
��Left=�63   $��341,234,0,0q�6N   $	��Top=�6c   $��14(�6{   
���  ��6�   �� 5"   
   -   5         ��Name$ ButtonBalance��5"      $��Balance Total��6(   $��Center=�6@   $��0,15,0,0q�6]   $	��Top=�6o   $��41��6�   $	��165��6�   
������ $��24(�6�   $��2,2,2,2q�6�   $��Arial)�6�   $H BAcá podrá observar todo el flujo de dinero entre sus dos cuentas��6.  �� 5#   
   -   5        $ LabelCantidadTotal��5#      $��₡ 0��6,   $��Center=�6:   $��0,66,0,0q�6W   $	��Top=�6i   $��Arial)�6�   $��18(�6�   �� 5$   
   $��Periodo��6   $
��Left=�6"   $��
77,359,0,0q�6=   $	��Top=�6Q   $��16(�6i   �� 5%   
   -   5        $ LabelPeriodo��5%      $��
Enero 2023��6&   $
��Left=�6;   $��	77,10,0,0q�6V   $��Bottom=�6i   $��16(�6�   $
��Bold"�6�   �� 5&   
   $��Balance Mensual��6   $
��Left=�6*   $��339,269,0,0q�6E   $	��Top=�6Z   $��16(�6r   �� 5'   
   -   5        $ LabelBalanceMensual��5'      $��₡ 0��6-   $
��Left=�6;   $��339,305,0,0q�6V   $	��Top=�6k   �� 5(   
   -   5        $ ButtonConsultarCuentas��5(      $��Consultar Cuentas��61   $��Center=�6k   $��	0,344,0,0q�6�   $	��Top=�6�   $��41��6�   $	��182��6�   
������ $��18(�6�   $��2,2,2,2q�6�   $��Arial)�6  $M GAcá puede consultar los movimientos de sus cuentas de forma individual��6>  &   System.Windows.Controls.Calendar  5)   
   -   5        $��
Calendario��5)         DisplayMode$
 Year=�6%   	   SelectionMode$
	 None=�68   $y�Hidden=�6M   $��12,30,593,78q�5*   >   $��Bottom=�6T   5+      �� 5,   
   -   5        $ ButtonPeriodo��5,      $
��Left=�6(   $��10,0,0,5q�6C   $��Bottom=�6U   $��62��6�   $��62��6�   
������ $��18(�6�   $��2,2,2,2q�6�   $K EAcá podrá ver los distintos periodos en que se realizan movimientos��6  .��5-      �� $��/Calendar Icon.png��6   $��52��60   $��62��6<   $
��Left=�6G   $	��Top=�6b   5.      5/      51      