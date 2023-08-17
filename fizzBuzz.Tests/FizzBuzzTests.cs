namespace fizzBuzz.Tests;
using FluentAssertions;
using FizzBuzzKata;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(1, "1")]
    public void ShouldReturnFizzOrBuzzOrFizzBuzz(int number, string expectedWord)
    {
        var sut = new FizzBuzz();
        var result = sut.Calculate(number);
        result.Should().Be(expectedWord);
    }
}