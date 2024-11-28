using System;
using System.Linq;
using 

0 references
class MoreArrays
0 references

class Template {
  static void Main() {

    string[] colors = {"Garent", "Gold", "Purple", "Teal", "Sliver"}
    // LOOPING THROUGH ARRAYS -- The old way.
    for (int i = 0; i < colors.Length; i++)
    {
      Console.WriteLine(colors[i]);
    }

  // Looping though Array Practice
  int[] numbers = {-17, 45, -745, 25, 1777, 1, 0, 77, 745, -1777};
  // Your loop should iterate through the entire array.
  // Print the value on the screen.
  // If the number is even, print that on the screen.
  // If the numnber is odd, print that to the screen.

  foreach (int i in numbers)
  {
    Console.WriteLine(i)
    if (i % 2== 0) // MODULUS DIVIDES AND RETURNS THE REMAINDER.
    {
      Console.WriteLine("This number is even.\n")
    }
    else
  }
  Console.WriteLine("This number is even.\n")
  }

  // MULTIDIMENSIONAL ARRAYS
  // THIS CLASS WILL ONLY USE 2 DIMENSIONAL
  int[,] nums = {{2, 4, 6}, {-1, 0, 1}};

  // Acessing items in 2d arrays
  Console.WriteLine(nums[0,1]);
  Console.WriteLine(nums[1,1]);

  // CHANGING ELEMENTS
  nums[1,2] = 9001;
  // CHANGE ANY ELEMENTS FROM THE FIRST ARRAY
  nums[0,2] = 502;

  // LOOPING THROUGH 2D ARRAYS
  foreach (int i in nums)
  {
    Console.WriteLine(i);
  }

  // LOOPING THROUGH 2D ARRAYS -- HARD MORE
  for (int i=0; i < nums.GetLength(0); i++)
  {
    for (int j=0; j < nums.GetLength(1); j++)
    {
      Console.WriteLine(nums[i, j]);
    }
  }
  }     //DO NOT TOUCH
}       // DO NOT TOUCH 