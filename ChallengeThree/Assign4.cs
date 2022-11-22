using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ChallengeThree
{
    class Assign4
    {
        static void Main()
        {
            Stack stk = new Stack();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Push("Gayathri");
            Console.WriteLine("Stack items before pop");
            foreach (Object obj in stk)
            {
                Console.WriteLine(obj);
            }
            stk.Pop();
            stk.Pop();



            Console.WriteLine("Stack items after pop");
            foreach (Object obj in stk)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("The number of elements in the stack: " + stk.Count);
            Console.WriteLine("Does the stack contain the element 1: " + stk.Contains(1));
            Console.ReadKey();
        }
    }
}

