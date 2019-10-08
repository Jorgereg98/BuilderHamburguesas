using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class BaguetteArrachera : BaguetteBuilder
    {
        public BaguetteArrachera(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _baguette = new Baguette
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Arrachera",
                Foto = "BaguetteArrachera.png",
                Costo = 70,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _baguette.Ingredientes.Add("Pimientos");
            _baguette.Ingredientes.Add("Cebolla");
            _baguette.Ingredientes.Add("Lechuga");
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "Incluidas";
        }
    }
}
