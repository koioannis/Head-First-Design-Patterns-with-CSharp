using Chapter_03___The_Decorator_Pattern.Components;
using Chapter_03___The_Decorator_Pattern.Decorators;
using Xunit;

namespace Tests.Chapter_03___The_Decorator_Pattern
{
    public class EspressoComponentTests
    {
        private BeverageComponent _sut;

        public EspressoComponentTests()
        {
            _sut = new EspressoComponent();
        }

        [Fact]
        public void EspressoComponentWithoutDecoratorsShouldReturn2AsPrice()
        {
            Assert.Equal(2, _sut.Cost());
        }
        
        [Fact]
        public void EspressoComponentWithoutDecoratorsShouldReturnDefaultDescription()
        {
            Assert.Equal("Espresso", _sut.Description);
        }

        [Fact]
        public void EspressoComponentWithDecoratorShouldReturnCorrectPrice()
        {
            // mocha costs 0.2
            _sut = new MochaDecorator(_sut);

            Assert.Equal(2.2, _sut.Cost());
        }
        
        [Fact]
        public void EspressoComponentWithDecoratorShouldReturnCorrectDescription()
        {
            // mocha costs 0.2
            _sut = new MochaDecorator(_sut);

            Assert.Equal("Espresso, Mocha", _sut.Description);
        }
    }
}