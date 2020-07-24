namespace DesignPatterns.AbstractFactory
{
    public class WidgetFactory : IWidgetFactory
    {
        public IWidget CreateWidget()
        {
            return new Widget();
        }
    }
}