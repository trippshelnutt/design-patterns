namespace DesignPatterns.AbstractFactory
{
    public class Thingy : IProduct
    {
        private readonly string data;

        public Thingy(string data)
        {
            this.data = data;
        }
        
        public string Foo()
        {
            return data;
        }
    }
}