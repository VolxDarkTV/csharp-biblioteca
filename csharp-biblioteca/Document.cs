using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {

        public string Code { get; set; }

        //Disponibility & Date
        public bool Disponibility { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }


        public Document(string title, int year, string sector, int position, string autor)
        {
            this.Code = GenerateCode();
            this.Title = title;
            this.Year = year;
            this.Sector = sector;
            this.Position = position;
            this.Autor = autor;

            this.Disponibility = true;

        }

        
        public string Title { get; set; }
        public int Year { get; set; }
        public string Sector { get; set; }
        public int Position { get; set; }
        public string Autor { get; set; }

        public string GenerateCode()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var code = new string(Enumerable.Repeat(chars, 9)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return code;
        }
    }
}
