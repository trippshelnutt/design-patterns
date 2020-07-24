namespace DesignPatterns.FactoryMethod
{
    public class Thingy : IThingy
    {
        private readonly string data;

        private Thingy(string data)
        {
            this.data = data;
        }
        
        public static IThingy Create(string data)
        {
            return new Thingy(data);     
        }
        
        public string Bar()
        {
            return data;
        }
    }
}