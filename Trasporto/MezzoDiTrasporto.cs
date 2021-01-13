using System;

namespace Trasporto
{
    public abstract class MezzoDiTrasporto
    {
        private ushort nruote { get; set; }
        private Colore colore { get; set; }
        private int nmarce { get; set; }
        private string marca { get; set; }

        public override string ToString() { }

    }
}
