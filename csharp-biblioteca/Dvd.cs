using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Document
    {

        public Dvd(string code, string title, int year, string sector, int position, string autor, int timing) : base(title, year, sector, position, autor)
        {
            this.Timing = timing;
        }

        public int Timing { get; set; }

    }
}
