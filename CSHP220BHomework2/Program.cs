using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP220BHomework2
{
    class Program
    {
        static void Main(string[] args)
        {

            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            //1. Display to the console, all the passwords that are "hello". Hint: Where
            Console.WriteLine("LIST OF USERS WHOSE PASSWORD IS 'hello'");
            var helloPasswordUsers = users.Where(x => x.Password == "hello");
            foreach(var user in helloPasswordUsers)
            {
                Console.WriteLine($"{user.Name} - {user.Password}");

            }


            //2. Delete any passwords that are the lower-cased version of their Name. 
            //Do not just look for "steve". It has to be data-driven. Hint: Remove or RemoveAll
            //Console.WriteLine("\n\rLIST OF USERS/PASSWORDS PRIOR TO STEP 2 IN THE HOMEWORK");
            //foreach (var user in users)
            //{
            //    Console.WriteLine($"{user.Name} - {user.Password}");

            //}

            //Delete passwords that are the lower-cased version of their Name. 
            //users.Where((x) => x.Password == x.Name.ToLower()).ToList().ForEach(x => x.Password = null);

            //As per Sabet in Discussions forum, "you are removing the entire user not just the password".
            //canvas.uw.edu/courses/1260564/discussion_topics/4806125
            users.RemoveAll((x) => x.Password == x.Name.ToLower());



            //Console.WriteLine("\n\rLIST OF USERS/PASSWORDS AFTER TO STEP 2 IN THE HOMEWORK");
            //foreach (var user in users)
            //{
            //    Console.WriteLine($"{user.Name} - {user.Password}");

            //}


            //3. Delete the first User that has the password "hello". Hint: First or FirstOrDefault.
            users.Remove(users.First(x => x.Password == "hello"));


            //4. Display to the console the remaining users with their Name and Password.
            Console.WriteLine("\n\rFINAL LIST OF USERS/PASSWORDS");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} - {user.Password}");

            }

        }
    }
}
