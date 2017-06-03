using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Empleado
    {
        //atributos
        private string userName;
        private string pass;

        //propiedades
        public string UserName
        {
            get { return userName; }
            set 
            {
                if (value.Trim().Length > 5)
                { userName = value; }
                else
                { throw new Exception("El nombre de usuario debe tener al menos 6 caracteres."); }
            }
        }

        public string Pass
        {
            get { return pass; }
            set 
            {
                if (value.Trim().Length == 10)
                { pass = value; }
                else
                { throw new Exception("La contrasena debe tener 10 caracteres."); }
            }
        }

        //constructor
        public Empleado(string pUserName, string pPass)
        {
            UserName = pUserName;
            Pass = pPass;
        }
    }
}
