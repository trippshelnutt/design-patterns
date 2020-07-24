namespace DesignPatterns.FactoryMethod
{
    public class Widget : IWidget
    {
        private Widget()
        {
        }

        public static IWidget Create()
        {
            return new Widget();
        }
        
        public string Foo()
        {
            return "Widget";
        }
    }
}