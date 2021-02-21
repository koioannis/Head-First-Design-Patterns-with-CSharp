using Chapter_01___The_Strategy_Pattern;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;
using Chapter_01___The_Strategy_Pattern.Behaviors.Quack;
using Xunit;

namespace Tests
{
    public class MallardDuckTest
    {
        private readonly Duck _sut;

        public MallardDuckTest()
        {
            _sut = new MallardDuck();
        }

        [Fact]
        public void QuackingShouldQuack() 
        {
            Assert.Equal("Quack!!!", _sut.PerformQuack());
        }

        [Fact]
        public void FlyShouldFlyWithWings()
        {
            Assert.Equal("I'm flying!", _sut.PerformFly());
        }

        [Fact]
        public void DisplayShouldDisplayAMallardDuck()
        {
            Assert.Equal("I'm a Mallard duck", _sut.Display());
        }

        [Fact]
        public void SwimShouldSwim()
        {
            Assert.Equal("All ducks float, even decoys!", _sut.Swim());
        }

        [Fact]
        public void FlyBehaviorShouldChangeOnRuntime()
        {
            _sut.FlyBehavior = new FlyRocketPowered();
            Assert.Equal("I'm flying with a rocket!", _sut.PerformFly());
        }

        [Fact]
        public void QuackBehaviorShouldChangeOnRuntime()
        {
            _sut.QuackBehavior = new MuteQuack();
            Assert.Equal("Silence...", _sut.PerformQuack());
        }
        
    }
}