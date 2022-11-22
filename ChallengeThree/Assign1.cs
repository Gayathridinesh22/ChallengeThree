using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree
{
    internal class Assign1
    {
        public class student
        {
            private string name;
            private int id;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public void displaydetails()
            {
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Id:" + id);
            }
        }
        static void Main(string[] args)
        {
            student obj = new student();
            obj.Name = "Gayathri";
            obj.Id = 41;
            obj.displaydetails();
            Console.WriteLine("\n press any key to exit.....");
            Console.ReadLine();
        }
    }
}


