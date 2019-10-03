using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class BigMacBuilder : HamburguesaBuilder
    {
        public BigMacBuilder(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _hamburguesa = new Hamburguesa
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Big Mac",
                Foto = "big-mac.png",
                Costo = 80,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Extra pan");
            _hamburguesa.Ingredientes.Add("Queso americano");
            _hamburguesa.Ingredientes.Add("Cebolla");
            _hamburguesa.Ingredientes.Add("Pepinillos");
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Aderezo Big Mac");
            
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "Incluidas";
        }
    }
}
