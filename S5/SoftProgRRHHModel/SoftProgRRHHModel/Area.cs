using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgRRHHModel
{
    public class Area
    {
        private int idArea;
        private string nombre;
        private bool activo;

        public Area()
        {

        }
        public Area(int idArea, string nombre, bool activo)
        {
            this.idArea = idArea;
            this.nombre = nombre;
            this.activo = activo;
        }

        public int IdArea { get => idArea; set => idArea = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Activo { get => activo; set => activo = value; }

        public void mostrarDatos()
        {
            System.Console.WriteLine(idArea + ". " + nombre);
        }
    }
}
