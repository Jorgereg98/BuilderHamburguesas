using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public interface ICocinar
    {
        void Cocinar();
        void Cocinar(TipoPanEnum tipoPan, double costo, string nombre, string foto, TipoCarneEnum tipoCarne, List<string> ingredientes, string papas);
    }
}
