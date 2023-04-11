using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : Document
    {

        public Book(string title, int year, string sector, int position, string autor, int pages) : base(title, year, sector, position, autor)
        {
            this.Pages = pages;
        }

        public int Pages { get; set; }

    }
}
