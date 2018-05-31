# Define
def hailstone(n):
  if n == 1:
    return [1]

  elif n % 2 == 0:
    return [n] + hailstone(int(n / 2))
  
  else:
    return [n] + hailstone(3 * n + 1)


# Test
for i in range(1, 100):
  print("%d: %s" % (i, str(hailstone(i))))

