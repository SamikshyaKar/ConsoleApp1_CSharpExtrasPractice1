using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
    public class STNAME
    {
        public string FName { get; set; }

        public string LName { get; set; }

        public STNAME(string fname, string lname)
        {

            FName = fname;
            LName = lname;
        }

        public override string ToString()
        {
            return " " + FName + " " + LName;
        }
    }
   public  class Trial_8
    {
        //STNAME[] studame = new STNAME[2];


        public static void sortarraylistexps()
        {
            STNAME[] studnames = { new STNAME("Samu", "Dhamu"), new STNAME("Ramu", "Tuamu") };
            foreach (STNAME obj in studnames) {
                Console.WriteLine();
                Console.Write(" " + obj); }

            Array.Sort(studnames, (st1, st2) => st1.FName.CompareTo(st2.FName));
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("After Sorting with Lambda");
            foreach (STNAME obj1 in studnames)
            {
                Console.WriteLine();
                Console.Write(" " + obj1);

            }
            Array.Sort(studnames, (st1, st2) => st1.LName.CompareTo(st2.LName));
            Console.WriteLine();
            Console.WriteLine("***********!!!!!!!!!*************");
            Console.WriteLine("After SECOND  Sorting with Lambda");
            foreach (STNAME obj1 in studnames)
            {
                Console.WriteLine();
                Console.Write(" " + obj1);

            }


            Array.Sort(studnames, delegate (STNAME stname1, STNAME stname2)
            {
                return stname1.FName.CompareTo(stname2.FName);
            });


            Console.WriteLine();
            Console.WriteLine("***********!!!!!!!!!*************");
            Console.WriteLine("After Third   Sorting with Delegate");
            foreach (STNAME obj1 in studnames)
            {
                Console.WriteLine();
                Console.Write(" " + obj1);

            }
        }

      

    }
}
