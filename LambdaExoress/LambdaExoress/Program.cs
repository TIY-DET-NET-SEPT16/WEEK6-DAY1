using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] someVals = { 10, 20, 30, 5, 2, 40, 5, 7 };

            //int numGreateThan10 = 0;

            //for (int i = 0; i < someVals.Length; i++)
            //{
            //    if (someVals[i] > 10)
            //        numGreateThan10++;
            //}

            //int numMoreThan10 = someVals.Count(jas => jas > 10);

            //Console.WriteLine("Number greater than 10: {0}", numGreateThan10);
            //Console.WriteLine("Number greater than 10: {0}", numMoreThan10);

            List<User> myUsers = new List<User>();
            
            for(int i = 0; i < 20; i++)
            {
                User usr = new User();
                usr.Name = "Name: " + i;
                if (i % 2 == 0)
                    usr.Active = true;
                else
                    usr.Active = false;

                myUsers.Add(usr);
            }

            List<User> activeUsers = myUsers.Where(u => u.Active).ToList();

            List<User> anotherActiveUserList = new List<LambdaExpress.User>();
            foreach(User u in myUsers)
            {
                if (!u.Active)
                {
                    anotherActiveUserList.Add(u);
                }
            }

            Console.ReadLine();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public bool Active { get; set; }

        public User()
        {

        }
    }
}
