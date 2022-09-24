using FluentAssertions;
using Xunit;

namespace Demo.Tests
{
    public class PromoTests
    {
        [Fact]
        public void Age19_Apply_True()
        {
            // Arrange
            var promo = new Promo(19);


            // Act
            var act = promo.Apply();


            // Assert
            act.Should().BeTrue();
        }

        [Fact]
        public void Age68_IsSenior_True()
        {
            // Arrange
            var promo = new Promo(68);


            // Act
            var act = promo.IsSenior();


            // Assert
            act.Should().BeTrue();
        }

        [Fact]
        public void Age67_IsSenior_True()
        {
            // Arrange
            var promo = new Promo(67);


            // Act
            var act = promo.IsSenior();


            // Assert
            act.Should().BeTrue();
        }

        [Fact]
        public void Age66_IsSenior_False()
        {
            // Arrange
            var promo = new Promo(66);


            // Act
            var act = promo.IsSenior();


            // Assert
            act.Should().BeFalse();
        }
    }
}
