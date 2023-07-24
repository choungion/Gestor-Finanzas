using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestorFinanzas
{
    public class Balance
    {
        private float BalanceTotal = 0, BalanceCuentaBanco, BalanceCuentaEfectivo;
        public float BalanceTotalSetGet { get => BalanceTotal; set => BalanceTotal = value; }
        public float BalanceCuentaBancoSetGet { get => BalanceCuentaBanco; set => BalanceCuentaBanco = value; }
        public float BalanceCuentaEfectivoSetGet { get => BalanceCuentaEfectivo; set => BalanceCuentaEfectivo = value; }
        private static Balance Instancia;

        List<float> ListaFlujoDinero = new List<float>();
        List<int> ListaMeses = new List<int>();
        List<int> ListaAnual = new List<int>();
        List<string> ListaCategoria = new List<string>();
        List<string> ListaCuenta = new List<string>();

        public void IngresarListaFlujoDinero(float Flujo)
        {
            ListaFlujoDinero.Add(Flujo);
        }
        public void IngresarListaMeses(int Meses)
        {
            ListaMeses.Add(Meses);
        }
        public void IngresarListaAnual(int Anual) 
        {
            ListaAnual.Add(Anual);

            MessageBox.Show(ListaFlujoDinero[0] + "" + ListaMeses[0] + "" + ListaAnual[0] + "" + ListaCategoria[0] + "" + ListaCuenta[0]);
        }
        public void IngresarListaCategoria(string Categoria)
        {
            ListaCategoria.Add(Categoria);
        }
        public void IngresarListaCuenta(string Cuenta) 
        {
            ListaCuenta.Add(Cuenta);
        }
        public float MostrarBalanceTotal ()
        {
            foreach (float cantidad in ListaFlujoDinero)
            {
                BalanceTotal += cantidad;
            }
            return BalanceTotal;
        }
        public static Balance InstanciaBalance
        {
            get
            {
                if ( Instancia== null)
                {
                    Instancia = new Balance();
                }
                return Instancia;
            }
        }
    }
}
