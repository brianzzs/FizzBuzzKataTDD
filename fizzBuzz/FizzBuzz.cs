namespace FizzBuzzKata;
public class FizzBuzz
{
    public string Calculate(int number)
    {
        bool isDivisibleBy3 = number % 3 == 0;
        bool isDivisibleBy5 = number % 5 == 0;
        bool isNotDivisibleBy5or3 = !isDivisibleBy5 && !isDivisibleBy3;

        if (isDivisibleBy3 & isDivisibleBy5)
        {
            return "FizzBuzz";
        }
        else if (isDivisibleBy3 && !isDivisibleBy5)
        {
            return "Fizz";
        }
        else if (isDivisibleBy5 && !isDivisibleBy3)
        {
            return "Buzz";
        }
        else if (isNotDivisibleBy5or3)
        {
            return $"{number.ToString()}";
        }

        return "It shouldnt be here!";
    }
}