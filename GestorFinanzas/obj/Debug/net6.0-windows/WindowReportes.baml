   M S B A M L   `   `   `  ����  GestorFinanzas#    GestorFinanzas.WindowReportes   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  WindowReportes��5   	   $	��941��6    $	��800��6-    � 
ResizeMode$ NoResize=�5   	   .��5	      � .+�5
   
   o� -   5        $��MenuPrincipal��5
      $��46��6   $��46��60   $��	10,10,0,0q�6;   $
��Left=�6N   $	��Top=�6i   $��2q�6�   .@�5      m� $�� ��6   $��45��6!   $��45��6,    m� Icon 5      �� 5      $��/Hamburger_icon.svg.png��6   $��35��6=   $��0,-15,-19,-14q�6H   .@�5      m� -   5         m�Name$ MenuItemTransacciones��5      $��Transacciones��6:    m� IsCheckable$ False��6Q   6f   m� 5      -   5        $ MenuItemReportes��5      $��Reportes��65   $ False��6G   5      5      �� 5   
   $��Gastos por categorias��6   $
��Left=�60   $��	69,56,0,0q�6K   $	��Top=�6^   �� 5   
   $��Gastos por cuentas��6   $��Center=�6-   $��0,56,0,0q�6J   $	��Top=�6\   �� 5   
   $��Gastos por mes��6   $
��Left=�6)   $��
625,56,0,0q�6D   $	��Top=�6X   �� 5   
   $��Ingresos por categorias��6   $
��Left=�62   $��
64,490,0,0q�6M   $	��Top=�6a   �� 5   
   $��Ingresos por cuentas��6   $��Center=�6/   $��	0,490,0,0q�6L   $	��Top=�6_   �� 5   
   $��Ingresos por mes��6   $
��Left=�6+   $��609,490,0,0q�6F   $	��Top=�6[   �� 5   
   -   5         ��Name$ ComboBoxAno��5      $
��Left=�6(   $��
625,10,0,0q�6C   $	��Top=�6W   $	��120��6o    �� 
IsEditable$ False��6�    �� SelectedIndex$ 0��6�   �� 5   
   -   5         ��Name$ LstBoxGastosCategorias��5      $
��Left=�62   $��0,82,0,0q�6M   $	��Top=�6_   $	��408��6w   $	��252��6�   �� 5   
   -   5        $ LstBoxGastosCuentas��5      $��Center=�6/   $��0,82,0,0q�6L   $	��Top=�6^   $	��408��6v   $	��252��6�   �� 5   
   -   5        $ LstBoxGastosMes��5      $��Right=�6+   $��
548,82,0,0q�6G   $	��Top=�6[   $	��408��6s   $	��252��6�   �� 5   
   -	   5        $ LstBoxIngresosCategorias��5      $
��Left=�64   $��	0,516,0,0q�6O   $��Bottom=�6b   $	��408��6}   $	��252��6�   �� 5   
   -
   5        $ LstBoxIngresosCuentas��5      $��Center=�61   $��Bottom=�6N   $	��408��6i   $	��252��6v   $��	0,516,0,0q�6�   �� 5   
   -   5        $ LstBoxIngresosMes��5      $��Right=�6-   $��Bottom=�6I   $	��408��6d   $	��252��6q   $��548,517,0,0q�6}   5       5!      