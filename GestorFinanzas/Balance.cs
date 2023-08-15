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
        private string UsuarioActivo;

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
        List<float> FlujoReporte = new List<float>();
        List<string> FechaFlujo = new List<string>();
        List<string> ListaUsuarios = new List<string>();
        #region Metodos para agregar elementos a las listas
        public void IngresarListaFlujoDinero(float Flujo)
        {
            ListaFlujoDinero.Add(Flujo);
        }
        public void IngresarListaMeses(int Meses)
        {
            ListaMeses.Add(Meses);
            MessageBox.Show(ListaMeses[0].ToString());
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
        public void IngresarListaUsuarios()
        {
            ListaUsuarios.Add(UsuarioActivo);
        }
        public void IngresarUsuarioActivo(string Usuario)
        {
            UsuarioActivo = Usuario;
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
                if (ListaMeses[i] == mes && ListaUsuarios[i] == UsuarioActivo)
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
                if (ListaCuenta[i] == cuenta && ListaUsuarios[i] == UsuarioActivo)
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
                if (ListaCategoria[i] == "Transferencia" && ListaFlujoDinero[i] > 0 && ListaUsuarios[i] == UsuarioActivo)
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
                if (ListaCuenta[i] == cuenta && ListaUsuarios[i] == UsuarioActivo)
                {
                    CategoriasEncontradas.Add(ListaCategoria[i]);
                    ListaBalanceEfectivo.Add(ListaFlujoDinero[i]);
                    IndicesEncontrados.Add(i);
                    CuentasEncontradas.Add(ListaCuenta[i]);
                }
            }
        }
        public void BuscarAno(int ano)
        {
            AnosEncontrados.Clear();
            IndicesEncontrados.Clear();
            CategoriasEncontradas.Clear();
            CuentasEncontradas.Clear();
            MesesEncontrados.Clear();
            FlujoReporte.Clear();
            for (int i = 0; i < ListaAnual.Count; i++)
            {
                if (ListaAnual[i].Equals(ano) && ListaUsuarios[i] == UsuarioActivo)
                {
                    AnosEncontrados.Add(ListaAnual[i]);
                    IndicesEncontrados.Add(i);
                    CategoriasEncontradas.Add(ListaCategoria[i]);
                    CuentasEncontradas.Add(ListaCuenta[i]);
                    MesesEncontrados.Add(ListaMeses[i]);
                    FlujoReporte.Add(ListaFlujoDinero[i]);
                }
            }
        }
        #endregion
        #region Metodos para obtener la suma de las cantidades obtenidas
        public float MostrarBalanceTotal()
        {
            BalanceTotal = 0;
            for (int i = 0; i < ListaUsuarios.Count; i++)
            {
                if (ListaUsuarios[i] == UsuarioActivo)
                {
                    BalanceTotal += ListaFlujoDinero[i];
                }
            }
            return BalanceTotal;
        }

        public float MostrarTransferencias()
        {
            Transferencias = 0;
            for (int i = 0; i < ListaTransferencias.Count; i++)
            {
                if (ListaUsuarios[i] == UsuarioActivo)
                {
                    Transferencias += ListaTransferencias[i];
                }
            }
            return Transferencias;
        }
        public float MostrarIngresoMensual()
        {
            IngresoMensual = 0;
            BuscarTransferencias();
            for (int i = 0; i < ListaBalanceMensual.Count; i++)
            {
                if (ListaBalanceMensual[i] >= 0)
                {
                    IngresoMensual += ListaBalanceMensual[i];
                }
            }
            if (IngresoMensual == 0)
            {
                IngresoMensual = 0;
            }
            else
            {
                IngresoMensual = IngresoMensual - MostrarTransferencias();
            }
            return IngresoMensual;
        }
        public float MostrarGastoMensual()
        {
            GastoMensual = 0;
            BuscarTransferencias();
            for (int i = 0; i < ListaBalanceMensual.Count; i++)
            {
                if (ListaBalanceMensual[i] <= 0)
                {
                    GastoMensual += ListaBalanceMensual[i];
                }
            }
            if (GastoMensual == 0)
            {
                GastoMensual = 0;
            }
            else
            {
                GastoMensual = GastoMensual + MostrarTransferencias();
            }
            return GastoMensual;
        }
        public float MostrarBalanceMensual()
        {
            BalanceMensual = 0;
            for (int i = 0; i < ListaBalanceMensual.Count; i++)
            {
                BalanceMensual += ListaBalanceMensual[i];
            }
            return BalanceMensual;
        }
        public float MostrarBalanceEfectivo()
        {
            BalanceCuentaEfectivo = 0;
            for (int i = 0; i < ListaBalanceEfectivo.Count; i++)
            {
                BalanceCuentaEfectivo += ListaBalanceEfectivo[i];
            }
            return BalanceCuentaEfectivo;
        }
        public float MostrarBalanceBanco()
        {
            BalanceCuentaBanco = 0;
            for (int i = 0; i < ListaBalanceBanco.Count; i++)
            {
                BalanceCuentaBanco += ListaBalanceBanco[i];
            }
            return BalanceCuentaBanco;
        }
        #endregion
        #region Metodos para obtener las listas completas
        public List<string> ObtenerCategorias()
        {
            return CategoriasEncontradas;
        }
        public List<string> ObtenerCuentas()
        {
            return CuentasEncontradas;
        }
        public List<int> ObtenerMeses()
        {
            return MesesEncontrados;
        }
        public List<float> ObtenerFlujoReportes()
        {
            return FlujoReporte;
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
                if (ListaCuenta[i] == cuenta && ListaUsuarios[i] == UsuarioActivo)
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
