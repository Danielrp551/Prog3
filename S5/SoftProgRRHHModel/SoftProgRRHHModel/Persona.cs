using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgRRHHModel
{
    public class Persona
    {
        private int idPersona;
        private string dni;
        private string nombre;
        private string apellidoPaterno;
        private char genero;
        private DateTime fechaNacimiento;

        public Persona(){ }

        public Persona(int idPersona, string dni, string nombre, string apellidoPaterno, char genero, DateTime fechaNacimiento)
        {
            this.idPersona = idPersona;
            this.dni = dni;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.genero = genero;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string DNI { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
