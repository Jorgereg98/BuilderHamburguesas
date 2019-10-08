using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public abstract class BaguetteBuilder : ComidaBuilder
    {
        protected Baguette _baguette;

        public string TipoCarne { get; set; }
        public string TipoPan { get; set; }

        public Baguette ObtenerBaguette() { return _baguette; }

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
            return _baguette;
        }
    }
}
