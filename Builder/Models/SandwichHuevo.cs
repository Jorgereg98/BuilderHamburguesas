using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;

namespace Builder.Models
{
    public class SandwichHuevo : SandwichBuilder
    {
        public SandwichHuevo(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _sandwich = new Sandwich
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Huevo",
                Foto = "SandwichHuevo.png",
                Costo = 25,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _sandwich.Ingredientes.Add("Huevo");
            _sandwich.Ingredientes.Add("Lechuga");

        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "No Incluidas";
        }
    }
}
