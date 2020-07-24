namespace DesignPatterns.FactoryMethod
{
    public class Widget : IProduct
    {
        private Widget()
        {
        }

        public static IProduct Create()
        {
            return new Widget();
        }
        
        public string Foo()
        {
            return "Widget";
        }
    }
}