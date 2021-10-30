using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
    public class Name
    {
        public string Fname { get; set; }
        public string LName { get; set; }

        public Name(string fname, string lname)
        {
            Fname = fname;
            LName = lname;
        }

        public override string ToString()
        {
            return " " + Fname + " " + LName;
        }

    }
    public class Trial_6
    {
        public static void SortNameclassArray()
        {
            Name[] names = { new Name("Samu", "Dhamu"),
                             new Name("RamoeS", "Sambha"),
                             new Name("yattrea" , "Attuywq")};

            foreach (Name varname in names)
            {
                Console.WriteLine();
                Console.Write(" " + varname );

            }

            Array.Sort(names, delegate (Name name1, Name name2)
            {
                return name1.Fname.CompareTo(name2.Fname);
            });



            Console.WriteLine();
            Console.WriteLine("After Sorted Names[]");

            foreach (Name varname in names)
            {
                Console.WriteLine();
                Console.Write(" " +varname);

            }

        }
    }

}