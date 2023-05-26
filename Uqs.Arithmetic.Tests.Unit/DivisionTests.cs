using System;
using Xunit;

namespace Uqs.Arithmetic.Tests.Unit;

public class DivisionTests
{
  [Fact]
  public void Divide_DivisibleIntegers_WholeNumber()
  {
    // Arrange
    int dividend = 10;
    int divisor = 5;
    decimal expectedQuotient = 2;

    // Act
    decimal actualQuotient = Division.Divide(dividend, divisor);

    // Assert
    Assert.Equal(expectedQuotient, actualQuotient);
  }

  [Fact]
  public void Divide_IndivisibleIntegers_DecimalNumber()
  {
    // Arrange 
    int dividend = 10;
    int divisor = 4;
    decimal expectedQuotient = 2.5M;

    // Act
    decimal actualQuotient = Division.Divide(dividend, divisor);

    // Assert
    Assert.Equal(expectedQuotient, actualQuotient);
  }

  [Fact]
  public void Divide_ZeroDivisor_DivideByZeroException()
  {
    // Arrange 
    int dividend = 10;
    int divisor = 0;

    // Act
    Exception e = Record.Exception(() =>
      Division.Divide(dividend, divisor));

    // Assert
    Assert.IsType<DivideByZeroException>(e);
  }
}