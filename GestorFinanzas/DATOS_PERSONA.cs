using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFinanzas
{           //DATOS DE LAS PERSONAS QUE SE VAN A REGISTRAR EN LA APLICACION
    public class DATOS_PERSONA
    {
        #region ATRIBUTOS GENERALES DE LA CLASE -----------------------------------------------------
        //ATRIBUTOS
       
        private string NOMBRE;
        private string NUM_TELEFONO;
        private string CEDULA;
        private string CONTRASENA;
        private string USUARIO;

        #endregion

        #region CONSTRUCTORES -----------------------------------------------------------------------

        //ESTE CONSTRUCTOR ES PARA INICIAR UN USUARIO ADMIN DE PRUEBA A LA APP
       

        public DATOS_PERSONA(string nAME, string nUM_TELEFONO, string cEDULA, string password, string user)
        {
            this.NOMBRE = nAME;
            this.NUM_TELEFONO = nUM_TELEFONO;
            this.CEDULA = cEDULA;
            this.CONTRASENA = password;
            this.USUARIO = user;
            
        }




        #endregion

        #region METODOS PARA RETORNAR O IMPLEMENTAR DATOS--------------------------------------------
        //GETS Y SETS DE LOS ATRIBUTOS

        public void set_NOMBRE(string nombre) 
        { 
            this.NOMBRE=nombre;
        }
        public string get_NOMBRE()
        {
            return this.NOMBRE;
        }


        public void set_NUMERO(string numero_TEL) 
        {
            this.NUM_TELEFONO=numero_TEL;
        }
        public string get_NUMERO()
        {
            return (this.NUM_TELEFONO);
        }


        public void set_CEDULA(string cedula)
        {
            this.CEDULA = cedula;
        }
        public string get_CEDULA() 
        {
            return this.CEDULA;
        }

        public void set_CONTRASENA(string contrasena) 
        {
            this.CONTRASENA = contrasena;
        }
        public string get_CONTRASENA() {

          return (this.CONTRASENA);
        }

        public void set_USUARIO(string usuario) 
        {
            this.USUARIO=usuario;
        }
        public string get_USUARIO()
        {
            return(this.USUARIO);
        }

        #endregion


    }
}
