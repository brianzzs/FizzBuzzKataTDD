using FizzBuzzKata;
for (int i = 0; i <= 100; i++)
{
    var fizzBuzz = new FizzBuzz();
    var result = fizzBuzz.Calculate(i);
    Console.WriteLine(result);
}
