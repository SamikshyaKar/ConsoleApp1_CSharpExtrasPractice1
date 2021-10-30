using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CSharpExtrasPractice1
{
   public  class Sort_2
    {
        // C# code to linearly search x in arr[]. If x 
// is present then return its location, otherwise 
// return -1 


public class GFG
	{
		public static int search(int[] arr, int x)
		{
			int n = arr.Length;
			for (int i = 0; i < n; i++)
			{
				if (arr[i] == x)
					return i;
			}
			return -1;
		}

		// Driver code 
		public static void Linear_search_Display()
		{
                Console.WriteLine(" Welcome to Linear Search ");
                Console.WriteLine(" ***************** ");
			int[] arr = { 2, 3, 4, 10, 40 };
			int x = 10;

			// Function call 
			int result = search(arr, x);
			if (result == -1)
				Console.WriteLine(
					"Element is not present in array");
			else
				Console.WriteLine("Element is present at index "
								+ result);
		}
	}

	// This code is contributed by DrRoot_


}
}
