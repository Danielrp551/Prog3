using SoftBibController.DAO;
using SoftBibController.MySQL;
using SoftBibModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBib
{
    public class Program
    {
        static void Main(string[] args)
        {
            Prestamo prestamo = new Prestamo();
            //prestamo.Fechainicio = DateTime.Now;
            System.Console.WriteLine("Ingrese la fecha de inicio del prestamo (formato: yyyy-MM-dd):");
            prestamo.Fechainicio = DateTime.Parse(System.Console.ReadLine());
            prestamo.Estado = EstadoPrestamo.Activo;
            
            

            PrestamoDAO prestamo_dao = new PrestamoMySQL();

            int resultado = prestamo_dao.insertar(prestamo);
            if (resultado != 0)
                System.Console.WriteLine("Se registro el prestamo con exito");
            System.Console.ReadLine();

        }
    }
}
