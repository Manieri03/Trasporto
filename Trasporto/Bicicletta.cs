using System;
using System.Collections.Generic;
using System.Text;

namespace Trasporto
{
    public class Bicicletta:MezzoDiTrasporto
    {
        private const ushort NUMERO_RUOTE = 2;
        private double dimensioniTelaio { get; set; }

        public Bicicletta(Colore c, double dt)
        {
            dimensioniTelaio = dt;
            
        }

    }
}
