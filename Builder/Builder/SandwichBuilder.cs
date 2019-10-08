using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public abstract class SandwichBuilder : ComidaBuilder
    {
        protected Sandwich _sandwich;

        public string TipoCarne { get; set; }
        public string TipoPan { get; set; }

        public Sandwich ObtenerSandwich() { return _sandwich; }

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
            return _sandwich;
        }
    }
}
