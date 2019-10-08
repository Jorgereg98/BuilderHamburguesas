﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public abstract class HamburguesaBuilder : ComidaBuilder
    {
        protected Hamburguesa _hamburguesa;

        public string TipoCarne { get; set; }
        public string TipoPan { get; set; }

        public Hamburguesa ObtenerHamburguesa() { return _hamburguesa; }

        public virtual void PasoAñadirIngredientes()
        {

        }

        public virtual void PasoAñadirPapas()
        {

        }

        public override IComida Cocinar()
        {
            PasoAñadirIngredientes();
            PasoAñadirPapas();
            return _hamburguesa;
        }
    }
}
