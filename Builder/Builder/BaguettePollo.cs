using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;


namespace Builder.Builder
{
    public class BaguettePollo : BaguetteBuilder
    {
        public BaguettePollo(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _baguette = new Baguette
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Pollo",
                Foto = "BaguettePollo.png",
                Costo = 50,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _baguette.Ingredientes.Add("Queso americano");
            _baguette.Ingredientes.Add("Lechuga");
            _baguette.Ingredientes.Add("Jitomate");
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "Incluidas";
        }
    }
}
