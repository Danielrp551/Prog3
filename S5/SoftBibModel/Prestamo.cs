using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBibModel
{
    public class Prestamo
    {
        private int id_prestamo;
        private DateTime fechainicio;
        private DateTime fechaFin;
        private DateTime fechaDeEntrega;
        private EstadoPrestamo estado;

        public Prestamo()
        {

        }

        public int Id_prestamo { get => id_prestamo; set => id_prestamo = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaDeEntrega { get => fechaDeEntrega; set => fechaDeEntrega = value; }
        public EstadoPrestamo Estado { get => estado; set => estado = value; }
    }
}
