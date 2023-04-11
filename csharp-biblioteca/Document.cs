using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {

        public Document(string title, int year, string sector, int position, string autor)
        {
            this.Title = title;
            this.Year = year;
            this.Sector = sector;
            this.Position = position;
            this.Autor = autor;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public string Sector { get; set; }
        public int Position { get; set; }
        public string Autor { get; set; }
        //public bool disponibility { get; set; }

    }
}
