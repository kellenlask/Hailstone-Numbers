import java.util.Arrays;
import java.util.stream.IntStream;
import java.util.stream.Stream;
import java.util.stream.Collectors;

public class Hailstone {
  // Define
  public static IntStream hailStone(int n) {
    if(n == 1) {
      return Arrays.stream(new int [] {1});
    }

    return n % 2 == 0
            ? IntStream.concat(
              Arrays.stream(new int [] {n}),
              hailStone(n / 2)
            )
            : IntStream.concat(
              Arrays.stream(new int [] {n}),
              hailStone(3 * n + 1)
            );
  }

  // Test
  public static void main(String[] args) {
    for(int i = 1; i < 100; i++) {
      System.out.println(
        i + ": [" +
        String.join(
          ", ", 
          hailStone(i)
            .mapToObj(n -> n + "")
            .collect(Collectors.toList())
        ) + "]"
      );
    }
  }
}

