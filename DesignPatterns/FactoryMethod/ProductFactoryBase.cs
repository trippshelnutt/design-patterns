namespace DesignPatterns.FactoryMethod
{
    public abstract class ProductFactoryBase
    {
        protected abstract IProduct CreateSpecialProduct();
        
        public IProduct CreateProduct()
        {
            return CreateSpecialProduct();
        }
    }
}