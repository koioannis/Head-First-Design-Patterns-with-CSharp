using System.IO;
using System.Text;
using Chapter_04___The_Factory_Pattern.FactoryMethod.FactoryMethods;
using Chapter_04___The_Factory_Pattern.FactoryMethod.Products;
using Xunit;

namespace Tests.Chapter_04___The_Factory_Pattern.FactoryMethodTests
{
    public class NyPizzaStoreTests
    {
        private readonly PizzaStore _sut; 
        
        public NyPizzaStoreTests()
        {
            _sut = new NyPizzaStore();
        }
        
        [Fact]
        public void NyPizzaStoreShouldCreateANyStylePizzaWhenGivenCheeseAsType()
        {
            var content = new StringBuilder();
            var writer = new StringWriter(content);
            var nyStyleCheesePizza = new NYStyleCheesePizza();
            
            _sut.OrderPizza(writer, "cheese");
            
            

            var actual = content.ToString();
            var expected = $"Preparing {nyStyleCheesePizza.Name}\r\n" +
                           $"{nyStyleCheesePizza.Bake()}\r\n" +
                           $"{nyStyleCheesePizza.Cut()}\r\n" +
                           $"{nyStyleCheesePizza.Box()}\r\n";

            Assert.Equal(expected, actual);
        }
    }
}