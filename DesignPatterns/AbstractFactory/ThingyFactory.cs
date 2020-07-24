namespace DesignPatterns.AbstractFactory
{
    public class ThingyFactory : IThingyFactory
    {
        private readonly string data;

        // Thingy factory takes dependencies in constructor which can be injected
        public ThingyFactory(string data)
        {
            this.data = data;
        }
        
        public IThingy CreateThingy()
        {
            return new Thingy(data);
        }
    }
}