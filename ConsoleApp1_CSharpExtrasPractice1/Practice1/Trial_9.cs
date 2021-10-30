using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
    public class classListNames
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public classListNames(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }

        public classListNames()
        {
        }

        public override string ToString()
        {
            return (" " + FName + " " + LName);
        }
    }



    public class Trial_9
    {
        public static void ExperimentswithList()
        {
            Console.WriteLine();
            List<classListNames> listNames = new List<classListNames>();
            listNames.Add(new classListNames("A_Samu", "Z_Samu"));
            listNames.Add(new classListNames("Z_Samu", "Z_Samu"));
            listNames.Add(new classListNames("Z_Samu", "A_Samu"));
            listNames.Add(new classListNames("A_Samu", "A_Samu"));
            listNames.Add(new classListNames("A_Dhamu", "Z_Samu"));
            listNames.Add(new classListNames("A_Dhamu", "Z_Dhamu"));
            listNames.Add(new classListNames("Z_Dhamu", "Z_Samu"));
            listNames.Add(new classListNames("Z_Dhamu", "Z_Dhamu"));
            listNames.Add(new classListNames() { FName = "Wqqopa", LName = "Zertwa" });

            foreach(classListNames obj in listNames)
            {
                Console.WriteLine();
                Console.Write(" " +obj);
            }

            //listNames.Sort();
            listNames.Sort(delegate (classListNames name1, classListNames name2)
            {
                return name1.FName.CompareTo(name2.FName);
            });

            Console.WriteLine();
            Console.WriteLine(" AfTER FIRST SORTING s per delegate Method ", -26);

            foreach (classListNames obj in listNames)
            {
                Console.WriteLine();
                Console.Write(" " + obj);
            }
            Console.WriteLine();

            listNames.Sort((name1, name2) => name1.FName.CompareTo(name2.FName));

            Console.WriteLine("  AfTER SECOND SORTING as per LAMBDA  Method ", 26);

            foreach (classListNames obj in listNames)
            {
                Console.WriteLine();
                Console.Write(" " + obj);
            }
        }
    }
}
