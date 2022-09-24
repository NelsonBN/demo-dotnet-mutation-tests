using FluentAssertions;
using Xunit;

namespace Demo.Tests
{
    public class CalcTests
    {
        [Fact]
        public void FourAndFive_Sum_Nine()
        {
            // Arrange
            var calc = new Calc(4, 5);



            // Act
            var act = calc.Sum();


            // Assert
            act.Should().Be(9);
        }

        [Fact]
        public void NineAnd2_SubSeven()
        {
            // Arrange
            var calc = new Calc(9, 2);


            // Act
            var act = calc.Sub();


            // Assert
            act.Should().Be(7);
        }
    }
}
