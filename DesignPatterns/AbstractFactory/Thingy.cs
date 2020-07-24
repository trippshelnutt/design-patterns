namespace DesignPatterns.AbstractFactory
{
    public class Thingy : IThingy
    {
        private readonly string data;

        public Thingy(string data)
        {
            this.data = data;
        }
        
        public string Bar()
        {
            return data;
        }
    }
}