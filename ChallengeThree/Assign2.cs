﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree
{
    class Assign2
    {
        public class Users
        {
            public string Name = "Sivaangi krishnakumar";
            public string location = "Chennai";
            public int age = 22;
            public virtual void GetInfo()
            {
                Console.WriteLine("Name:{0}", Name);
                Console.WriteLine("Location:{0}", location);
            }
        }
        public class Details : Users
        {
            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine("Age:{0}", base.age);
            }
        }
        static void Main(string[] args)
        {
            Details d = new Details();
            d.GetInfo();
            Console.WriteLine("\npress any key to exit....");
            Console.ReadLine();
        }
    }
}
    