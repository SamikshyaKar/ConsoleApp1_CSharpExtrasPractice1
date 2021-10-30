using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1.Practice1
{
    public class StudentsForExp
    {
        public string Name { get; set; }
        public int ID { get; set; }

    }
    public  class Trial_7
    {
        int[] array = new int[10];
       
        int[] array1 = new int[] { 1, 2, 5, 6, 12, 23 };

        List<int> list = new List<int>();
        List<int> list1 = new List<int>(23);
        List<int> list2 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list3 = new List<int>() { 12, 23, 45, 67 };

        public static void ExperimentsWithlist_array()
        {
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            foreach(var a in bigCities)
            {
                Console.WriteLine();
                Console.Write(a + ", ");
            }

            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            foreach (int a in primeNumbers)
            {
                Console.WriteLine();
                Console.Write(a + ", ");
            }
            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            foreach (string a in cities)
            {
                Console.WriteLine();
                Console.Write(a + ", ");
            }

            List<StudentsForExp> studList = new List<StudentsForExp>()
            {
                new StudentsForExp(){ID=1, Name="Samu" },
                new StudentsForExp(){ID=2,Name="dhamu"}

            };

            foreach(StudentsForExp studentsForExp in studList)
            {
                Console.WriteLine();
                Console.WriteLine(studentsForExp.ID + " ** "+ studentsForExp.Name);
                Console.WriteLine($"{studentsForExp.ID,10} {studentsForExp.Name, 18}");

            }

            StudentsForExp[] studarray = new StudentsForExp[2];
            studarray[0] = new StudentsForExp();
            studarray[0].ID = 1;
            studarray[0].Name = "SSSSamu";
            studarray[1] = new StudentsForExp();
            studarray[1].Name = "DHAMU";           
            studarray[1].ID = 2;
            foreach(StudentsForExp students in studarray)
            {
                Console.WriteLine();
                Console.Write(students.Name+ " "+ " "+ students.ID);
                Console.WriteLine($"{students.Name, 10} {students.ID,10}");
                Console.WriteLine();
            }




        }
    }
}
