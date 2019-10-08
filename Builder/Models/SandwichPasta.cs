using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;

namespace Builder.Models
{
    public class SandwichPasta : SandwichBuilder
    {
        public SandwichPasta(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _sandwich = new Sandwich
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Pasta",
                Foto = "SandwichPasta.png",
                Costo = 35,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _sandwich.Ingredientes.Add("Macarrones");
            _sandwich.Ingredientes.Add("Queso americano");

        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "No Incluidas";
        }
    }
}
