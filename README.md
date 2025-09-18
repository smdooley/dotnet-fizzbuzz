# dotnet-fizzbuzz

## The Problem

We need to write a program that prints the numbers from 1 to n.

- If the number is divisible by 3, print "Fizz".
- If the number is divisible by 5, print "Buzz".
- If divisible by both 3 and 5, print "FizzBuzz".

Otherwise, just print the number.

We need to test divisibility:

- Use % (modulus operator) to check remainders.
- If i % 3 == 0, then divisible by 3.
- If i % 5 == 0, then divisible by 5.