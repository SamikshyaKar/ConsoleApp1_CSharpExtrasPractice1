using ConsoleApp1_CSharpExtrasPractice1.Practice1;
using System;
using ConsoleApp1_CSharpExtrasPractice1.SORTINGS_Geek;

namespace ConsoleApp1_CSharpExtrasPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!", 23);
            //Console.WriteLine("Hello World!!!!", -23);
            //Console.WriteLine($"Hello World!", 10, "********",5);
            //Console.WriteLine("    Hello World!", 12, "********", 11);
            //Console.WriteLine("    Hello World!", "********");

            //Trial_1.ReverseString();           
            //Console.WriteLine();
            //Console.WriteLine(Trial_1.ReverseStringSecond("SAMU"));
            //Trial_1.ReverseStringThird();
            //Console.WriteLine();
            //Trial_1.StringUpper();
            //Trial_2.Addition();
            //Trial_2.Addition(23, 45);
            //Trial_2.Division();
            //Trial_3.PrintAsciiValus();
            //Console.WriteLine();
            //Trial_3.calculatePower();
            //Trial_4.FindSize();
            //Console.WriteLine();
            //Trial_5.arraysort();
            //Trial_6.SortNameclassArray();
            //Trial_7.ExperimentsWithlist_array();
            //Trial_8.sortarraylistexps();
            //Trial_9.ExperimentswithList();
            //Console.WriteLine();
            //Console.WriteLine("    ********Inside Trial 10 EXPERIMENTS ");
            //Trial_10.MyExperiment1();
            //Trial_11.displayarraysdifferents();
            //Sort_1.sortbubblesort();
            //Sort_2.GFG.Linear_search_Display();
            //Sort_3.SelectionSort();
            //Sort_4.InsertionSort();
            ////Sort_5.D_Dsiplay_Quick_Sort();
            //Sort_6.GFG.Display();
            //Sort_7.Display_MERGERSORT();
            //Sort_8.MergeSort.Display_MERGERSORT();
            Console.WriteLine();
            int i = 2;
            int power = 5;
            int result = 1;
       while (power != 0)
            {
                result = result * i;
                power--;
            }
            Console.WriteLine(result);
            
        }
    }
}
