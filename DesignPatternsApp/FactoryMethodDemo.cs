using DesignPatterns.FactoryMethod;

namespace DesignPatternsApp
{
    public static class FactoryMethodDemo
    {
        public static void Run()
        {
            var product1 = Widget.Create();
            var product2 = Thingy.Create("Thingy");
            
            product1.Foo();
            product2.Foo();
            
            var factory1 = new WidgetFactory();
            var factory2 = new ThingyFactory("Thingy");

            product1 = factory1.CreateProduct();
            product2 = factory2.CreateProduct();

            product1.Foo();
            product2.Foo();
        }
    }
}