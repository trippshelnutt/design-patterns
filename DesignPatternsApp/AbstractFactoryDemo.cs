using DesignPatterns.AbstractFactory;

namespace DesignPatternsApp
{
    public static class AbstractFactoryDemo
    {
        public static void Run()
        {
            var factory1 = new WidgetFactory();
            var factory2 = new ThingyFactory("Thingy");
            
            var product1 = factory1.CreateProduct();
            var product2 = factory2.CreateProduct();

            product1.Foo();
            product2.Foo();
        }
    }
}