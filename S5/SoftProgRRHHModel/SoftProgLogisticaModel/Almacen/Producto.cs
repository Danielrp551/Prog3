﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgLogisticaModel.Almacen
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private string unidadMedida;
        private double precio;
        private bool activo;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
        public double Precio { get => precio; set => precio = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
