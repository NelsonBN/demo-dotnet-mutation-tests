using FluentAssertions;
using Xunit;

namespace Demo.Tests
{
    public class PromoTests
    {
        [Fact]
        public void Age19_Sum_Nine()
        {
            // Arrange
            var promo = new Promo(19);


            // Act
            var act = promo.Apply();


            // Assert
            act.Should().BeTrue();
        }

        [Fact]
        public void Age18_Sum_Nine()
        {
            // Arrange
            var promo = new Promo(19);


            // Act
            var act = promo.Apply();


            // Assert
            act.Should().BeTrue();
        }
    }
}
