using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Zona
    {
        //atributos
        private string departamento;
        private string codigo;
        private string nombre;
        private int habitantes;
        private List<string> servicios;

        //propiedades
        public string Departamento
        {
            get { return departamento; }
            set
            {
                if (value.Trim().Length == 1)
                {
                    switch (value.ToUpper())
                    {
                        case "A":
                            departamento = "A";
                            break;
                        case "B":
                            departamento = "B";
                            break;
                        case "C":
                            departamento = "C";
                            break;
                        case "D":
                            departamento = "D";
                            break;
                        case "E":
                            departamento = "E";
                            break;
                        case "F":
                            departamento = "F";
                            break;
                        case "G":
                            departamento = "G";
                            break;
                        case "H":
                            departamento = "H";
                            break;
                        case "I":
                            departamento = "I";
                            break;
                        case "J":
                            departamento = "J";
                            break;
                        case "K":
                            departamento = "K";
                            break;
                        case "L":
                            departamento = "L";
                            break;
                        case "M":
                            departamento = "M";
                            break;
                        case "N":
                            departamento = "N";
                            break;
                        case "O":
                            departamento = "O";
                            break;
                        case "P":
                            departamento = "P";
                            break;
                        case "Q":
                            departamento = "Q";
                            break;
                        case "R":
                            departamento = "R";
                            break;
                        case "S":
                            departamento = "S";
                            break;
                        default:
                            throw new Exception("Ingrese una letra valida.");
                    }
                }
                else
                { throw new Exception("El departamento debe ser la letra que lo identifica."); }
            }
        }

        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (value.Trim().Length == 3)
                { codigo = value; }
                else
                { throw new Exception("El codigo debe tener 3 letras."); }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set 
            {
                if (value.Trim().Length > 1)
                { nombre = value; }
                else
                { throw new Exception("Por favor ingrese un nombre."); }
            }
        }

        public int Habitantes
        {
            get { return habitantes; }
            set
            {
                if (value > 0)
                { habitantes = value; }
                else
                { throw new Exception("La cantidad de habitantes debe ser un numero positivo."); }
            }
        }

        public List<string> Servicios
        {
            get { return servicios; }
            set
            {
                if (value.Count >= 1)
                { servicios = value; }
                else
                { throw new Exception("Debe ingresar al menos debe contar con un servicio."); }
            }
        }

        //constructor
        public Zona(string pDepartamento,string pCodigo,string pNombre,int pHabitantes, List<string> pServicios)
        {
            Departamento = pDepartamento;
            Codigo = pCodigo;
            Nombre = pNombre;
            Habitantes = pHabitantes;
            Servicios = pServicios;
        }
    }
}
