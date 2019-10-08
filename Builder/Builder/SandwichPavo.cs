using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class SandwichPavo : SandwichBuilder
    {
        public SandwichPavo(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _sandwich = new Sandwich
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Pavo",
                Foto = "SandwichPavo.png",
                Costo = 50,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _sandwich.Ingredientes.Add("Cebolla");
            _sandwich.Ingredientes.Add("Jitomate");
            _sandwich.Ingredientes.Add("Lechuga");
        }

        public override void PasoAñadirPapas()
        {
            _sandwich.Papas = "Incluidas";
        }
    }
}
