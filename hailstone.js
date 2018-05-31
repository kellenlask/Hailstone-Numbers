// Define Hailstone
const hailstone = n => {
  if(n === 1) {
    return 1;
  }

  return n % 2 === 0 
           ? [n].concat(hailstone(n / 2))
           : [n].concat(hailstone(3 * n + 1))
};


// Test Hailstone
for(let i = 1; i < 100; i++) {
  console.log(i + ": " + JSON.stringify(hailstone(i)))
}

