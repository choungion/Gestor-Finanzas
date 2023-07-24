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
        private static Balance Instancia;

        List<float> ListaFlujoDinero = new List<float>();
        List<int> ListaDias = new List<int>();
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
        }
        public void IngresarListaCategoria(string Categoria)
        {
            ListaCategoria.Add(Categoria);
        }
        public void IngresarListaCuenta(string Cuenta) 
        {
            ListaCuenta.Add(Cuenta);
        }
        public void IngresarListaDias(int Dia)
        {
            ListaDias.Add(Dia);
        }
        public float MostrarBalanceTotal ()
        {
            BalanceTotal = 0;
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
