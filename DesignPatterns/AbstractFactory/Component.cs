namespace DesignPatterns.AbstractFactory
{
    public class Component : IComponent
    {
        private readonly string data;

        public Component(string data)
        {
            this.data = data;
        }
        
        public string Baz()
        {
            return data;
        }
    }
}