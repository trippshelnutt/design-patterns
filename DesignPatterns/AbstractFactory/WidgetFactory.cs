namespace DesignPatterns.AbstractFactory
{
    public class WidgetFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new Widget();
        }
    }
}