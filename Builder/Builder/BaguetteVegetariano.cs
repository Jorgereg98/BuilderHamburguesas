using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class BaguetteVegetariano : BaguetteBuilder
    {
        public BaguetteVegetariano(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _baguette = new Baguette
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Vegetariano",
                Foto = "BaguetteVegetariano.png",
                Costo = 60,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _baguette.Ingredientes.Add("Jitomate");
            _baguette.Ingredientes.Add("Cebolla");
            _baguette.Ingredientes.Add("Lechuga");
            _baguette.Ingredientes.Add("Aderezo");
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "Incluidas";
        }
    }
}
