using SoftProgLogisticaModel.Almacen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgLogisticaModel.Ventas
{
    public class LineaOrdenVenta
    {
        private Producto producto;

        private int idLineaOrdenVenta;
        private int cantidad;
        private double subtotal;
        private bool activo;

        public Producto Producto { get => producto; set => producto = value; }
        public int IdLineaOrdenVenta { get => idLineaOrdenVenta; set => idLineaOrdenVenta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
