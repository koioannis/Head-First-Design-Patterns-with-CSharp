using Chapter_01___The_Strategy_Pattern;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;
using Chapter_01___The_Strategy_Pattern.Behaviors.Quack;
using Xunit;

namespace Tests
{
    public class DecoyDuckTests
    {
        private readonly Duck _sut;

        public DecoyDuckTests()
        {
            _sut = new DecoyDuck();
        }

        [Fact]
        public void QuackingShouldNotQuack() 
        {
            Assert.Equal("Silence...", _sut.PerformQuack());
        }

        [Fact]
        public void FlyShouldFlyNoWay()
        {
            Assert.Equal("I can't fly", _sut.PerformFly());
        }

        [Fact]
        public void DisplayShouldDisplayADecoyDuck()
        {
            Assert.Equal("I'm a Decoy duck", _sut.Display());
        }

        [Fact]
        public void SwimShouldSwim()
        {
            Assert.Equal("All ducks float, even decoys!", _sut.Swim());
        }

        [Fact]
        public void FlyBehaviorShouldChangeOnRuntime()
        {
            // seems like some ducks made their dreams true
            _sut.FlyBehavior = new FlyWithWings();
            Assert.Equal("I'm flying!", _sut.PerformFly());
        }

        [Fact]
        public void QuackBehaviorShouldChangeOnRuntime()
        {
            _sut.QuackBehavior = new Squeack();
            Assert.Equal("Squeack!!!", _sut.PerformQuack());
        }
    }
}