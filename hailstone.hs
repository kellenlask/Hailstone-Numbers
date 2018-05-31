-- Definition
hailstone :: Int -> [Int]
hailstone n | n == 1 = [1]
            | mod n 2 == 0 = [n] ++ hailstone(quot n 2)
            | otherwise = [n] ++ hailstone(n * 3 + 1)

hailstoneStr :: Int -> String
hailstoneStr n = (show n) ++ ": " ++ (show $ hailstone n) ++ "\n"

-- Test
main :: IO()
main = mapM_ putStrLn $ map hailstoneStr [1..100]
