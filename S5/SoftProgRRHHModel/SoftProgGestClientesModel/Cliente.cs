﻿using SoftProgRRHHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgGestClientesModel
{
    public class Cliente : Persona
    {
        private double lineaCredito;
        private Categoria categoria;

        public Cliente()
        {

        }

        public double LineaCredito { get => lineaCredito; set => lineaCredito = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
    }
}
