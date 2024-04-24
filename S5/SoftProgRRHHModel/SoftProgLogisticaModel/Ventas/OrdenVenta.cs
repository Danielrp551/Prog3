using SoftProgGestClientesModel;
using SoftProgRRHHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgLogisticaModel.Ventas
{
    public class OrdenVenta
    {
        private Cliente cliente;
        private Empleado empleado;
        private LineaOrdenVenta[] lineasOrdenesVenta;

        private int idOrdenVenta;
        private double total;
        private DateTime fechaHora;
        private bool activo;


    }
}
