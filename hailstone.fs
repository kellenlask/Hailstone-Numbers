// Define
let rec hailstone n = 
  match n with 
  | n when n = 1 -> [|1|]
  | n when n % 2 = 0 -> Array.concat [ [|n|] ; hailstone(n / 2) ]
  | n -> Array.concat [ [|n|] ; hailstone(3 * n + 1) ]

// Test
for n in 1..100 do
  hailstone n
  |> Array.map string
  |> String.concat ", "
  |> sprintf "%d: [%s]" n
  |> System.Console.WriteLine

