   M S B A M L   `   `   `  ����I  EGestorFinanzas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GestorFinanzasGestorFinanzas  5   	   %    GestorFinanzas.WindowTransferir   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GestorFinanzas     5   	     � Title$  WindowTransferir��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   �� $��Cuenta de origen��6   $
��Left=�6+   $��
183,86,0,0q�6F   $	��Top=�6Z   $��Arial)�6r   $��16(�6�   �� 5   
   $��Cuenta de destino��6   $
��Left=�6,   $��
483,86,0,0q�6G   $	��Top=�6[   $��Arial)�6s   $��16(�6�   �� 5   
   -   5         ��Name$ ComboBoxCuentaOrigen��5      $
��Left=�61   $��153,119,0,0q�6L   $	��Top=�6a   $	��192��6y    �� SelectedIndex$ 2��6�   .@�5      �� $��Efectivo��6   �� 5      $��Banco��6   �� 5      $$��Seleccione la cuenta de origen��6   5      �� 5   
   -   5        $ ComboBoxCuentaDestino��5      $
��Left=�62   $��493,119,0,0q�6M   $	��Top=�6b   $	��120��6z   ${�False��6�   .@�5      �� $��Efectivo��6   �� 5      $��Banco��6   5      �� 5   
   $��Center=�6   $��48��6-   $��	0,100,0,0q�69   $	��Top=�6L   $��52��6d   $��/transfer.png��6o   �� 5   
   -   5         ��Name$ ButtonTransferir��5      $��
Transferir��6+   $
��Left=�6@   $��360,247,0,0q�6[   $	��Top=�6p   $��36��6�   $��86��6�   6�   �� 5   
   -   5        $ ButtonCancelar��5      $��Cancelar��6)   $
��Left=�6<   $��360,316,0,0q�6W   $	��Top=�6l   $��36��6�   $��86��6�   6�   �� 5   
   -   5         ��Name$ TxtBoxCantidad��5      $
��Left=�6*   $��343,153,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��120��6�   6�   �� 5   
   -   5        $ ButtonFechaingreso��5      $
��Left=�6-   $��276,180,0,0q�6H   $	��Top=�6]   $��42��6�   $��42��6�   
������ $��18(�6�   $��0,0,0,0q�6�   .��5      �� $��/Calendar Icon.png��6   $��42��60   $��41��6<   $
��Left=�6G   $	��Top=�6b   5      &   System.Windows.Controls.Calendar  5   
   -   5        $��
Calendario��5         SelectionMode$ 
SingleDate=�6%   $��87,153,517,0q�5      $	��Top=�6!   $y�Hidden=�5   B   �� 5   
   -   5         ��Name$ 
LabelFecha��5      $-��'Seleccione la fecha de la transferencia��6$   $
��Left=�6V   $��323,191,0,0q�6q   $	��Top=�6�   5!      5"      