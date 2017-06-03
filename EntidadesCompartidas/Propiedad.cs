using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Propiedad
    {
        //atributos
        private int numPadron;
        private string direccion;
        private int precio;
        private string accion;
        private int banios;
        private int habitaciones;
        private int metros;
        private Zona unaZona;
        private Empleado unEmpleado; 

        //propiedades
        public int NumPadron
        {
            get { return numPadron; }
            set
            {
                if (value > 0)
                { numPadron = value; }
                else
                { throw new Exception("El padron debe ser un numero positivo."); }
            }
        }

        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (value.Trim().Length > 1)
                { direccion = value; }
                else
                { throw new Exception("Por favor ingrese una direccion."); }
            }
        }

        public int Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                { precio = value; }
                else
                { throw new Exception("El precio debe ser un numero positivo."); }
            }
        }

        public string Accion
        {
            get { return accion; }
            set 
            {
                if (value.Trim().ToLower() == "venta" || value.Trim().ToLower() == "alquiler" || value.Trim().ToLower() == "permuta")
                { accion = value; }
                else
                { throw new Exception("Las unicas acciones posibles son : venta, alquiler o permuta."); }
            }
        }

        public int Banios
        { }

        public int Habitaciones
        { }

        public int Metros
        { }

        public Zona UnaZona
        { }

        public Empleado UnEmpleado
        { }
        //constructor

    }
}
