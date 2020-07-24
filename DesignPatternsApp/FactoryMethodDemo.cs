using DesignPatterns.FactoryMethod;

namespace DesignPatternsApp
{
    public static class FactoryMethodDemo
    {
        public static void Run()
        {
            var widget = Widget.Create();
            var thingy = Thingy.Create("Thingy");
            
            widget.Foo();
            thingy.Bar();
        }
    }
}