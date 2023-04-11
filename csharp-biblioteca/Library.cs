using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {

        //public void LibraryNameSearch() 
        //{

        //    User u1 = new User("vincenzo", "FOTI", "vincewnzo.foti02@gmail.coms", "password", "+39 3664248926");
        //    User u2 = new User("giGi", "FOTI", "vincewnzo.foti@gmail.com", "password", "+39 3664248926");
        //    User u3 = new User("test", "FOTI", "vincewnzo.foti@gmail.com", "password", "+39 3664248926");
        //    User u4 = new User("vincenzo", "FOTI", "vincewnzo.foti04@gmail.com", "password", "+39 3664248926");
        //    List<User> users = new List<User>();
        //    users.Add(u1);
        //    users.Add(u2);
        //    users.Add(u3);
        //    users.Add(u4);

        //    Console.WriteLine("Ricerca x nome:");
        //    string nameToFind = Console.ReadLine();

        //    List<User> usersWithName = users.Where(x => x.Name.ToLower() == nameToFind.ToLower()).ToList();

        //    if (usersWithName.Count > 0)
        //    {
        //        Console.WriteLine($"Users with name '{nameToFind}':");
        //        foreach (User user in usersWithName)
        //        {
        //            Console.WriteLine($"{user.Name} {user.Last} {user.Email}");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"No users found with name '{nameToFind}'.");
        //    }

        //}

        public List<Document> Documents = new List<Document>();

        public void LibraryBookSearch()
        {
            
            //Set instance
            Book b1 = new Book("Balena", 2002, "Narrative", 25, "judsb", 400);
            Book b2 = new Book("pippo", 2002, "Narrative", 25, "judsb", 400);
            Book b3 = new Book("paperino", 2002, "Fumetto", 10, "judsb", 400);
            Book b4 = new Book("The promised Neverland", 2019, "Manga", 10, "xiao", 50);

            //Creation List
            Documents.Add(b1);
            Documents.Add(b2);
            Documents.Add(b3);
            Documents.Add(b4);

           
            //Code view
            string test1 = b1.Code;
            string test2 = b2.Code;
            string test3 = b3.Code;
            string test4 = b4.Code;


            Console.WriteLine($"Libro1: {test1} - Libro2: {test2} - Libro3: {test3} - Libro4: {test4}");

            Console.WriteLine("Ricerca x title or book code:");
            string nameToFind = Console.ReadLine();

            //Search filter Title
            List<Document> bookWithTitle = Documents.Where(x => (x.Title.ToLower() == nameToFind.ToLower()) || (x.Code == nameToFind)).ToList();
            

            if (bookWithTitle.Count > 0)
            {
                Console.WriteLine($"Book with title/code'{nameToFind}':");
                foreach (Book book in bookWithTitle)
                {
                    Console.WriteLine($"{book.Title} {book.Year} {book.Autor}");

                    if(book.Disponibility == true)
                    {
                        Console.WriteLine("Il libro/dvd è libero, vuoi noleggiarlo? S/n");
                        string userAnsware = Console.ReadLine();
                        if(userAnsware.ToLower() == "s")
                        {
                            book.Disponibility = false;
                            Console.WriteLine($"Congratulazioni hai noleggiato {book.Title}");
                            DateTime now = DateTime.Now;
                            book.DateStart = Convert.ToString($"{now.Date.Day}/{now.Date.Month}/{now.Date.Year}");
                            Console.WriteLine($"Data Inizio: {book.DateStart}");

                            Console.WriteLine("Inserire data di fine noleggio dd/mm/yyyy: ");
                            book.DateEnd = Console.ReadLine();
                            Console.WriteLine($"Data Fine: {book.DateEnd}");
                        }
                        else
                        {
                            Console.WriteLine("Non hai noleggiato :(");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Libro/Dvd Non disponibile al momento");
                    }
                }
            }
            else
            {
                Console.WriteLine($"No books found with title '{nameToFind}'.");
            }

            

        }



    }
}
