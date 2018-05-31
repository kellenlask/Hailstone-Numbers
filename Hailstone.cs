using System;
using System.Linq;

public class MainClass {
  // Define
  public static int[] Hailstone(int n) 
  {
    if(n == 1) {
      return new [] {1};
    }

    return n % 2 == 0
             ? new [] {n}.Concat(Hailstone(n / 2)).ToArray()
             : new [] {n}.Concat(Hailstone(3 * n + 1)).ToArray();
  }

  // Test
  public static void Main (string[] args) 
  {
    for(var i = 1; i < 100; i++) 
    {
      Console.WriteLine($"{i}: [{string.Join(", ", Hailstone(i))}]");
    }
  }
}

