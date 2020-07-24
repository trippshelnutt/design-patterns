namespace DesignPatterns.AbstractFactory
{
    public interface IComponentFactory
    {
        IComponent CreateComponent(string data);
    }
}