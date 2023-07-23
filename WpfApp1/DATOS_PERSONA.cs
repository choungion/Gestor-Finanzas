using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{           //DATOS DE LAS PERSONAS QUE SE VAN A REGISTRAR EN LA APLICACION
    public class DATOS_PERSONA
    {
        #region ATRIBUTOS GENERALES DE LA CLASE -----------------------------------------------------
        //ATRIBUTOS
        private static double iD = 0;
        private string NAME;
        private string NUM_TELEFONO;
        private string CEDULA;
        private string password;
        private string User;
        
        #endregion

        #region CONSTRUCTORES -----------------------------------------------------------------------
              
        //ESTE CONSTRUCTOR ES PARA INICIAR UN USUARIO ADMIN DE PRUEBA A LA APP
        public DATOS_PERSONA(string nombre_USUARIO,string Password )
        {
            iD++;
            this.User = nombre_USUARIO;
            this.password = Password;

        }

        public DATOS_PERSONA(string nAME, string nUM_TELEFONO, string cEDULA, string password, string user)
        {
           this.NAME = nAME;
           this.NUM_TELEFONO = nUM_TELEFONO;
           this.CEDULA = cEDULA;
           this.password = password;
           this.User= user;
           iD++;
        }

       


        #endregion

        #region METODOS PARA RETORNAR O IMPLEMENTAR DATOS--------------------------------------------
        //GETS Y SETS DE LOS ATRIBUTOS
        public string NAME1 { get => NAME; set => NAME = value; }
        public string NUM_TELEFONO1 { get => NUM_TELEFONO; set => NUM_TELEFONO = value; }
        public string CEDULA1 { get => CEDULA; set => CEDULA = value; }
        public string Password { get => password; set => password = value; }
        public string User1 { get => User; set => User = value; }

        #endregion


    }
}
