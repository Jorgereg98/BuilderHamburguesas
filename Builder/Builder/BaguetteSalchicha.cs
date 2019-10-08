using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class BaguetteSalchicha : BaguetteBuilder
    {
        public BaguetteSalchicha(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _baguette = new Baguette
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Salchicha",
                Foto = "BaguetteSalchicha.png",
                Costo = 50,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _baguette.Ingredientes.Add("Queso americano");
        }

        public override void PasoAñadirPapas()
        {
            _baguette.Papas = "No Incluidas";
        }
    }
}
