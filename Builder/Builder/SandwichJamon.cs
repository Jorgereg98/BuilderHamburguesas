using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class SandwichJamon : SandwichBuilder
    {
        public SandwichJamon(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _sandwich = new Sandwich
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Jamon",
                Foto = "SandwichJamon.png",
                Costo = 20,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _sandwich.Ingredientes.Add("Queso americano");
        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "No Incluidas";
        }
    }
}
