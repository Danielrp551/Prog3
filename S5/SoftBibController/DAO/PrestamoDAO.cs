using SoftBibModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBibController.DAO
{
    public interface PrestamoDAO
    {
        int insertar(Prestamo prestamo);
        int modificar(Prestamo prestamo);
        int eliminar(int id_prestamo);

        BindingList<Prestamo> listarTodas();
    }
}
