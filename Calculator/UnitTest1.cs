namespace CalculatorTest;
using Domain;
using FluentAssertions;

public class CalculatorTests
{
    [Fact]
    public void Sum_of_2_and_2_should_be_4()

    //{
    //    var calculator = new Calculator();
    //    var result = calculator.Sum(2, 2);

    //    //if (result != 4) throw new Exception($"The Sum(2,2) was expected to be 4 but it's {result}.");

    //    // FluentAssertions
    //    result.Should().Be(4);
    //}

    => new Calculator()
        .Sum(2, 2)
        .Should().Be(4);

  
}
