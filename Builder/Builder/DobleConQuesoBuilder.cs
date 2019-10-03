using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class DobleConQuesoBuilder : HamburguesaBuilder
    {
        public DobleConQuesoBuilder(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _hamburguesa = new Hamburguesa
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "Doble con queso",
                Foto = "hamb-doble-con-queso.png",
                Costo = 45,
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
            _hamburguesa.Papas = "No incluidas";
        }
    }
}
