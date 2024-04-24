using SoftProgRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgRRHHController.DAO
{
    public interface EmpleadoDAO
    {
        int insertar(Empleado empleado);
        int modificar(Empleado empleado);
        int eliminar(int idEmpleado);

        BindingList<Empleado> listarTodas();
    }
}
