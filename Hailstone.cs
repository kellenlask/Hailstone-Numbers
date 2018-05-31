using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass {
  // Define
  public static IEnumerable<int> Hailstone(int n) 
  {
    if(n == 1) {
      return new [] {1};
    }

    return n % 2 == 0
             ? new [] {n}.Concat(Hailstone(n / 2))
             : new [] {n}.Concat(Hailstone(3 * n + 1));
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

