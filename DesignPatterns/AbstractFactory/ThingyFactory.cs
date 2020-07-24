namespace DesignPatterns.AbstractFactory
{
    public class ThingyFactory : IProductFactory
    {
        private readonly string data;

        public ThingyFactory(string data)
        {
            this.data = data;
        }
        
        public IProduct CreateProduct()
        {
            return new Thingy(data);
        }
    }
}