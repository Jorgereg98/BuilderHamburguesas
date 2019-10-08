using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class Sandwich : IComida
    {
        public TipoPanEnum TipoPan { get; set; }
        public double Costo { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public TipoCarneEnum TipoCarne { get; set; }
        public List<string> Ingredientes { get; set; }
        public string Papas { get; set; }
        public string IngredientesString { get; set; }

        public Sandwich()
        {

        }

        public Sandwich(TipoPanEnum tipoPan, double costo, string nombre, string foto, TipoCarneEnum tipoCarne, List<string> ingredientes, string papas)
        {
            TipoPan = tipoPan;
            Costo = costo;
            Nombre = nombre;
            Foto = foto;
            TipoCarne = tipoCarne;
            Ingredientes = ingredientes;
            Papas = papas;
            IngredientesString = string.Join(",", ingredientes.ToArray());
        }

        public override string ToString()
        {
            return $"Sandwich {Nombre} / Tipo de pan: {TipoPan}, Tipo de carne: {TipoCarne}, " +
                $"Ingredientes: {string.Join("+", Ingredientes)}, Papas: {Papas}, Foto: {Foto}, Costo: {Costo}";
        }
    }
}
