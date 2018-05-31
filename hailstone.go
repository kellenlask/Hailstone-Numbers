package main

import "fmt"

func hailstone(n int) []int {
  switch {
    case n == 1: 
      return []int {1};    
    case n % 2 == 0:
      return append([]int {n}, hailstone(n / 2)...);  
    default: 
      return append([]int {n}, hailstone(3 * n + 1)...);
  }
}

func main() {
  for i := 1; i < 100; i++ {
    fmt.Printf("%v: %v\n", i, hailstone(i))
  }
}

