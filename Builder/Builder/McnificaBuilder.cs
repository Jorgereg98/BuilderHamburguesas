using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public class McnificaBuilder : HamburguesaBuilder
    {
        public McnificaBuilder(TipoPanEnum tipoPan, TipoCarneEnum tipoCarne)
        {
            _hamburguesa = new Hamburguesa
            {
                TipoPan = tipoPan,
                TipoCarne = tipoCarne,
                Ingredientes = new List<string>(),
                Nombre = "McNifica",
                Foto = "mc-nifica.png",
                Costo = 50,
            };
        }

        public override void PasoAñadirIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Queso americano");
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Cebolla");
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Pepinillos");
            _hamburguesa.Ingredientes.Add("Catsup");
            _hamburguesa.Ingredientes.Add("Mostaza");
            _hamburguesa.Ingredientes.Add("Mayonesa");
        }

        public override void PasoAñadirPapas()
        {
            _hamburguesa.Papas = "Incluidas";
        }
    }
}
