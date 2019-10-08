using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class BaguetteJamon : BaguetteBuilder
    {
        public BaguetteJamon(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _baguette = new Baguette
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Jamon",
                Foto = "BaguetteJamon.png",
                Costo = 40,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _baguette.Ingredientes.Add("Queso americano");
            _baguette.Ingredientes.Add("Lechuga");
            _baguette.Ingredientes.Add("Jitomate");
            _baguette.Ingredientes.Add("Cebolla");
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "No Incluidas";
        }
    }
}
