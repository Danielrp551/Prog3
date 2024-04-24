using SoftProgRRHHController.DAO;
using SoftProgRRHHController.MySQL;
using SoftProgRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            AreaDAO area_dao = new AreaMySQL();
            do
            {
                System.Console.WriteLine("1. Insertar area.");
                System.Console.WriteLine("2. Listar todas las areas.");
                System.Console.WriteLine("3. Salir.");
                System.Console.WriteLine("Ingrese su opcion: ");
                resultado = Int32.Parse(System.Console.ReadLine());
                if(resultado == 1)
                {
                    Area area = new Area();
                    System.Console.WriteLine("Ingrese el nombre del area: ");
                    area.Nombre = System.Console.ReadLine();
                    if (area_dao.insertar(area) != 0)
                        System.Console.WriteLine("El area se ha registrado con exito");
                }
                if(resultado == 2)
                {
                    BindingList<Area> areas = area_dao.listarTodas();
                    foreach(Area area in areas)
                        area.mostrarDatos();
                }
            }while (resultado!=3);
        }
    }
}
