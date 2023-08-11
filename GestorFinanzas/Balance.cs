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
        private float BalanceTotal = 0, BalanceCuentaBanco, BalanceCuentaEfectivo, IngresoMensual, GastoMensual, BalanceMensual, Transferencias;
        private static Balance Instancia;

        

        List<float> ListaFlujoDinero = new List<float>();

        List<int> ListaDias = new List<int>();

        List<int> ListaMeses = new List<int>();

        List<int> ListaAnual = new List<int>();

        List<string> ListaCategoria = new List<string>();

        List<string> ListaCuenta = new List<string>();

        List<int> MesesEncontrados = new List<int>();

        List<int> AnosEncontrados = new List<int>();

        List<int> IndicesEncontrados = new List<int>();

        List<float> ListaBalanceMensual = new List<float>();

        List<float> ListaBalanceEfectivo = new List<float>();

        List<float> ListaBalanceBanco = new List<float>();

        List<string> CuentasEncontradas = new List<string>();

        List<float> ListaTransferencias = new List<float>();

        List<string> CategoriasEncontradas = new List<string>();

        List<string> FechaFlujo = new List<string>();

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
        #region Metodos para Buscar el flujo de dinero por categoria, tipo de cuenta, mes, ano, dia
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
        public void BuscarCuentaBanco(string cuenta)
        {
            ListaBalanceBanco.Clear();
            IndicesEncontrados.Clear();
            CuentasEncontradas.Clear();
            CategoriasEncontradas.Clear();
            for (int i = 0; i < ListaCuenta.Count; i++)
            {
                if (ListaCuenta[i] == cuenta)
                {
                    ListaBalanceBanco.Add(ListaFlujoDinero[i]);
                    CategoriasEncontradas.Add(ListaCategoria[i]);
                    IndicesEncontrados.Add(i);
                    CuentasEncontradas.Add(ListaCuenta[i]);
                }
            }
        }
        public void BuscarTransferencias()
        {
            ListaTransferencias.Clear();
            for (int i = 0; i < ListaCategoria.Count; i++)
            {
                if (ListaCategoria[i] == "Transferencia" && ListaFlujoDinero[i] > 0)
                {
                    ListaTransferencias.Add(ListaFlujoDinero[i]);
                }
            }
        }
        public void BuscarCuentaEfectivo(string cuenta)
        {
            ListaBalanceEfectivo.Clear();
            IndicesEncontrados.Clear();
            CuentasEncontradas.Clear();
            CategoriasEncontradas.Clear();
            for (int i = 0; i < ListaCuenta.Count; i++)
            {
                if (ListaCuenta[i] == cuenta)
                {
                    CategoriasEncontradas.Add(ListaCategoria[i]);
                    ListaBalanceEfectivo.Add(ListaFlujoDinero[i]);
                    IndicesEncontrados.Add(i);
                    CuentasEncontradas.Add(ListaCuenta[i]);
                }
            }
        }
        public void BuscarAno(string ano)
        {
            AnosEncontrados.Clear();
            IndicesEncontrados.Clear();
            for (int i = 0; i < ListaAnual.Count; i++)
            {
                if (ListaAnual[i].Equals(ano))
                {
                    AnosEncontrados.Add(ListaAnual[i]);
                    IndicesEncontrados.Add(i);
                }
            }
        }
        #endregion
        #region Metodos para obtener la suma de las cantidades obtenidas
        public float MostrarBalanceTotal()
        {
            BalanceTotal = 0;
            foreach (float cantidad in ListaFlujoDinero)
            {
                BalanceTotal += cantidad;
            }
            return BalanceTotal;
        }

        public float MostrarTransferencias()
        {
            Transferencias = 0;
            foreach (float cantidad in ListaTransferencias)
            {
                Transferencias += cantidad;
            }
            return Transferencias;
        }
        public float MostrarIngresoMensual()
        {
            IngresoMensual = 0;
            BuscarTransferencias();
            var ingresos = ListaBalanceMensual.Where(n => n > 0);
            foreach (float cantidad in ingresos)
            {
                IngresoMensual += cantidad;
            }
            IngresoMensual = IngresoMensual - MostrarTransferencias();
            return IngresoMensual;
        }
        public float MostrarGastoMensual()
        {
            GastoMensual = 0;
            BuscarTransferencias();
            var gastos = ListaBalanceMensual.Where(n => n < 0);
            foreach (float cantidad in gastos)
            {
                GastoMensual += cantidad;
            }
            GastoMensual = GastoMensual + MostrarTransferencias();
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

        public float MostrarBalanceEfectivo()
        {
            BalanceCuentaEfectivo = 0;
            foreach (float cantidad in ListaBalanceEfectivo)
            {
                BalanceCuentaEfectivo += cantidad;
            }
            return BalanceCuentaEfectivo;
        }

        public float MostrarBalanceBanco()
        {
            BalanceCuentaBanco = 0;
            foreach (float cantidad in ListaBalanceBanco)
            {
                BalanceCuentaBanco += cantidad;
            }
            return BalanceCuentaBanco;
        }


        public int numero1 = 0;

        public int retornarnum() {
            return numero1;
        }

        public void setnum(int numero) {
            this.numero1 = numero;
        }
       


        #endregion
        #region Metodos para obtener las listas completas
        public List<string> ObtenerCategorias()
        {
            return CategoriasEncontradas;
        }
        public List<float> ObtenerListaBalanceBanco()
        {
            return ListaBalanceBanco;
        }
        public List<float> ObtenerListaBalanceEfectivo()
        {
            return ListaBalanceEfectivo;
        }
        public List<string> ObtenerFecha(string cuenta)
        {
            FechaFlujo.Clear();
            for (int i = 0; i < ListaCuenta.Count; i++)
            {
                if (ListaCuenta[i] == cuenta)
                {
                    FechaFlujo.Add(ListaDias[i] + "/" + ListaMeses[i] + "/" + ListaAnual[i]);
                }
            }
            return FechaFlujo;
        }
        #endregion
        public static Balance InstanciaBalance
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new Balance();
                }
                return Instancia;
            }
        }
    }
}
