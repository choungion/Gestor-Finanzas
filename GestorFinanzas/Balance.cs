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
        private float BalanceTotal = 0, BalanceCuentaBanco, BalanceCuentaEfectivo, IngresoMensual, GastoMensual, BalanceMensual;
        private static Balance Instancia;

        List<float> ListaFlujoDinero = new List<float>();
        List<int> ListaDias = new List<int>();
        List<int> ListaMeses = new List<int>();
        List<int> ListaAnual = new List<int>();
        List<string> ListaCategoria = new List<string>();
        List<string> ListaCuenta = new List<string>();
        List<int> MesesEncontrados = new List<int>();
        List<int> IndicesEncontrados = new List<int>();
        List<float> ListaBalanceMensual =  new List<float>();
        #region Metodos para agregar elementos a las listas
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
        #endregion
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
        public void BuscarMes(int mes)
        {
            ListaBalanceMensual.Clear();
            IndicesEncontrados.Clear();
            MesesEncontrados.Clear();
            for (int i = 0; i < ListaMeses.Count; i++)
            {
                if (ListaMeses[i] == mes)
                {
                    ListaBalanceMensual.Add(ListaFlujoDinero[i]);
                    IndicesEncontrados.Add(i);
                    MesesEncontrados.Add(ListaMeses[i]);
                }
            }
        }
        public float MostrarIngresoMensual()
        {
            IngresoMensual = 0;
            var ingresos = ListaBalanceMensual.Where(n => n > 0);
            foreach (float cantidad in ingresos)
            {
                IngresoMensual += cantidad;
            }
            return IngresoMensual;
        }
        public float MostrarGastoMensual()
        {
            GastoMensual = 0;
            var gastos = ListaBalanceMensual.Where(n => n < 0);
            foreach (float cantidad in gastos)
            {
                GastoMensual += cantidad;
            }
            return GastoMensual;
        }
        public float MostrarBalanceMensual()
        {
            BalanceMensual = 0;
            foreach (float cantidad in ListaBalanceMensual)
            {
                BalanceMensual += cantidad;
            }
            return BalanceMensual;
        }
    }
}
