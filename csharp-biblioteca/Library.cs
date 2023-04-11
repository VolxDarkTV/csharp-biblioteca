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
            User u2 = new User("gigi", "FOTI", "vincewnzo.foti@gmail.com", "password", "+39 3664248926");
            User u3 = new User("test", "FOTI", "vincewnzo.foti@gmail.com", "password", "+39 3664248926");
            User u4 = new User("vincenzo", "FOTI", "vincewnzo.foti04@gmail.com", "password", "+39 3664248926");
            List<User> users = new List<User>();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);

            string nameToFind = "vincenzo";

            List<User> usersWithName = users.Where(x => x.Name == nameToFind).ToList();

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

        

    }
}
