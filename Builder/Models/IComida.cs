using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public interface IComida
    {
        TipoPanEnum TipoPan { get; set; }
        double Costo { get; set; }
        string Nombre { get; set; }
        string Foto { get; set; }
        TipoCarneEnum TipoCarne { get; set; }
        List<string> Ingredientes { get; set; }
        string Papas { get; set; }
        string IngredientesString { get; set; }
    }
}
