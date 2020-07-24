namespace DesignPatterns.FactoryMethod
{
    public class ThingyFactory : ProductFactoryBase
    {
        private readonly string data;

        public ThingyFactory(string data)
        {
            this.data = data;
        }
        
        protected override IProduct CreateSpecialProduct()
        {
            return Thingy.Create(data);
        }
    }
}