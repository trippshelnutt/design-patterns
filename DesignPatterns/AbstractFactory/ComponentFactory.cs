namespace DesignPatterns.AbstractFactory
{
    public class ComponentFactory : IComponentFactory
    {
        // Component factory takes dependencies at run time
        public IComponent CreateComponent(string data)
        {
            return new Component(data);
        }
    }
}