namespace DesignPatterns.FactoryMethod
{
    public class Thingy : IProduct
    {
        private readonly string data;

        private Thingy(string data)
        {
            this.data = data;
        }
        
        public static IProduct Create(string data)
        {
            return new Thingy(data);     
        }
        
        public string Foo()
        {
            return data;
        }
    }
}