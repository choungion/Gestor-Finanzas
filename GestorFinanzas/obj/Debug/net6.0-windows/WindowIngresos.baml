   M S B A M L   `   `   `  ����I  EGestorFinanzas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GestorFinanzasGestorFinanzas  5   	   #    GestorFinanzas.WindowIngresos   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GestorFinanzas     5   	     � Title$  WindowIngresos��5   	   $	��450��6    $	��800��6-   .��5
      � .+�5   
   �� $%��Ingrese la cantidad a registrar��6   $��Center=�6:   $��0,42,0,0q�6W   $	��Top=�6i   $��Arial)�6�   $��18(�6�   �� 5   
   -   5         ��Name$ TxtBoxCantidad��5      $��Center=�6*   $��0,78,0,0q�6G    �� TextWrapping$
 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��202��6�   $��29��6�   6�   �� 5   
   -   5         ��Name$ ButtonGuardar��5      $��Guardar��6(   $
��Left=�6:   $��461,377,0,0q�6U   $	��Top=�6j   $��Arial)�6�   $��16(�6�   6�   �� 5   
   -   5        $ ButtonCancelar��5      $��Cancelar��6)   $
��Left=�6<   $��276,377,0,0q�6W   $	��Top=�6l   $��Arial)�6�   $��16(�6�   6�   �� 5   
   -   5         ��Name$ ComboBoxCuentas��5      $
��Left=�6,   $��372,139,0,0q�6G   $	��Top=�6\   $	��152��6t    �� SelectedIndex$ 2��6�   .@�5      �� $��Efectivo��6   �� 5      $��Banco��6   �� 5      $��Seleccione la cuenta��6   5      �� 5   
   -   5         ��Name$ 
ImageIcono��5      $
��Left=�6$   $��65��6?   $��299,118,0,0q�6K   $	��Top=�6`   $��65��6x   &   System.Windows.Controls.Calendar  5   
   -   5        $��
Calendario��5         SelectionMode$ 
SingleDate=�6%   $��88,146,516,0q�5      $	��Top=�6!   $y�Hidden=�5   B   �� 5   
   -   5        $ ButtonFechaingreso��5      $��Center=�6-   $��-180,20,0,0q�6J   $��Center=�6_   $��42��6�   $��42��6�   
������ $��18(�6�   $��0,0,0,0q�6�   .��5      �� $��/Calendar Icon.png��6   $��42��60   $��41��6<   $
��Left=�6G   $	��Top=�6b   5      �� 5   
   -   5         ��Name$ 
LabelFecha��5      $%��Seleccione la fecha del ingreso��6$   $
��Left=�6N   $��336,217,0,0q�6i   $	��Top=�6~   �� 5   
   $��	Categoria��6   $
��Left=�6$   $��289,296,0,0q�6?   $	��Top=�6T   �� 5   
   -	   5        $ ComboBoxCategorias��5      $
��Left=�6/   $��372,300,0,0q�6J   $	��Top=�6_   $	��152��6w   $ 4��6�   .@�5      �� $��Salario��6   �� 5      $��Inversiones��6   �� 5       $��Renta��6   �� 5!      $��Regalo��6   �� 5"      $��Seleccione la categoria��6   5#      5$      5%      