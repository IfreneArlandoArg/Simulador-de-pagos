using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whyNot
{
    public class Beca
    {
        public string Código { get; set; }

        public DateTime Fecha_Ortogamiento { get; set; }

        public decimal Importe { get; set; }

        public Beca(string código, DateTime fecha_Ortogamiento, decimal importe)
        {
            Código = código;
            Fecha_Ortogamiento = fecha_Ortogamiento;
            Importe = importe;
        }
    }
}
