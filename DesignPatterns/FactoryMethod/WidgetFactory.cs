namespace DesignPatterns.FactoryMethod
{
    public class WidgetFactory : ProductFactoryBase
    {
        protected override IProduct CreateSpecialProduct()
        {
            return Widget.Create();
        }
    }
}