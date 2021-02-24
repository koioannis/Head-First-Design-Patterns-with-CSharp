using System.IO;
using System.Text;
using Chapter_04___The_Factory_Pattern.AbstractFactory;
using Xunit;

namespace Tests.AbstractFactoryTests
{
    public class NyPizzaStoreTests
    {
        private NyPizzaStore _sut;
        
        public NyPizzaStoreTests()
        {
            _sut = new NyPizzaStore();
        }

        [Fact]
        public void NyPizzaStoreShouldAddTheCorrectIngredientsWhenOrderPizzaIsCalled()
        {
            var content = new StringBuilder();
            var writer = new StringWriter(content);

            _sut.OrderPizza(writer, "cheese");
            
            

            var actual = content.ToString();
            var expected = "Preparing New York Style Cheese Pizza\r\n" +
                           "Adding Thin Crust Dough\r\n" +
                           "Adding Marinara Sauce\r\n" +
                           "Adding Reggiano Cheese\r\n";

            Assert.Equal(expected, actual);
        }
    }
}