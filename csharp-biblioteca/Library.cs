using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {

        public void LibraryNameSearch() 
        {

            User u1 = new User("vincenzo", "FOTI", "vincewnzo.foti02@gmail.coms", "password", "+39 3664248926");
            User u2 = new User("giGi", "FOTI", "vincewnzo.foti@gmail.com", "password", "+39 3664248926");
            User u3 = new User("test", "FOTI", "vincewnzo.foti@gmail.com", "password", "+39 3664248926");
            User u4 = new User("vincenzo", "FOTI", "vincewnzo.foti04@gmail.com", "password", "+39 3664248926");
            List<User> users = new List<User>();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);

            Console.WriteLine("Ricerca x nome:");
            string nameToFind = Console.ReadLine();

            List<User> usersWithName = users.Where(x => x.Name.ToLower() == nameToFind.ToLower()).ToList();

            if (usersWithName.Count > 0)
            {
                Console.WriteLine($"Users with name '{nameToFind}':");
                foreach (User user in usersWithName)
                {
                    Console.WriteLine($"{user.Name} {user.Last} {user.Email}");
                }
            }
            else
            {
                Console.WriteLine($"No users found with name '{nameToFind}'.");
            }

        }


        public void LibraryBookSearch()
        {
            //Set instance
            Book b1 = new Book("Balena", 2002, "Narrative", 25, "judsb", 400);
           
            //Creation List
            List<Book> users = new List<Book>();
            users.Add(b1);
            

            Console.WriteLine("Ricerca x nome:");
            string nameToFind = Console.ReadLine();

            //Search filter
            List<Book> bookWithName = users.Where(x => x.Title.ToLower() == nameToFind.ToLower()).ToList();

            if (bookWithName.Count > 0)
            {
                Console.WriteLine($"Users with name '{nameToFind}':");
                foreach (Book book in bookWithName)
                {
                    Console.WriteLine($"{book.Title} {book.Year} {book.Autor}");
                }
            }
            else
            {
                Console.WriteLine($"No users found with name '{bookWithName}'.");
            }
        }



    }
}
