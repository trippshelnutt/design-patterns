using DesignPatterns.AbstractFactory;

namespace DesignPatternsApp
{
    public static class AbstractFactoryDemo
    {
        public static void Run()
        {
            var widgetFactory = new WidgetFactory();
            var thingyFactory = new ThingyFactory("Thingy");
            var componentFactory = new ComponentFactory();
            
            var widget = widgetFactory.CreateWidget();
            var thingy = thingyFactory.CreateThingy();
            var component = componentFactory.CreateComponent("Component");

            widget.Foo();
            thingy.Bar();
            component.Baz();
        }
    }
}