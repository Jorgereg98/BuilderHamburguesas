using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class McPolloBuilder : HamburguesaBuilder
    {
        public McPolloBuilder(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _hamburguesa = new Hamburguesa
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Mc Pollo",
                Foto = "mc-pollo.png",
                Costo = 30,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Mayonesa");
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "No incluidas";
        }
    }
}
