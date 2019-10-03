using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class CuartoDeLibraDobleConQuesoBuilder : HamburguesaBuilder
    {
        public CuartoDeLibraDobleConQuesoBuilder(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _hamburguesa = new Hamburguesa
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Cuarto de Libra doble con queso",
                Foto = "cuarto-de-libra-doble.png",
                Costo = 65,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Doble Queso americano");
            _hamburguesa.Ingredientes.Add("Cebolla");
            _hamburguesa.Ingredientes.Add("Pepinillos");
            _hamburguesa.Ingredientes.Add("Catsup");
            _hamburguesa.Ingredientes.Add("Mostaza");
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "Incluidas";
        }
    }
}
