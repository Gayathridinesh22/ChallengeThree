using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree
{
    class Student
    {
        int id;
        string name;
        int[] mark = new int[3];
        int total;
        public void read()
        {
            Console.WriteLine("Enter id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter marks of 3 subjects");
            for (int i = 0; i < 3; i++)
            {
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void calculate()
        {
            total = mark[0] + mark[1] + mark[2];
        }
        public void display()
        {
            Console.WriteLine("Id={0}\nName={1}\nTotal={2}", id, name, total);
        }
    }
    internal class Assign6
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the number of students");
            n = Convert.ToInt32(Console.ReadLine());
            Student[] obj = new Student[n];
            for (int i = 0; i < n; i++)
            {
                obj[i] = new Student();
                obj[i].read();
                obj[i].calculate();
                obj[i].display();
            }
            Console.ReadLine();
        }



    }
}
   