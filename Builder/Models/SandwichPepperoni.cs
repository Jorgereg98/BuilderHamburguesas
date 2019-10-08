using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;

namespace Builder.Models
{
    public class SandwichPepperoni : SandwichBuilder
    {
        public SandwichPepperoni(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _sandwich = new Sandwich
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Carnes Frias",
                Foto = "SandwichPepperoni.png",
                Costo = 40,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _sandwich.Ingredientes.Add("Queso americano");
            _sandwich.Ingredientes.Add("Pepino");
            _sandwich.Ingredientes.Add("Extra pan");
        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "Incluidas";
        }
    }
}
