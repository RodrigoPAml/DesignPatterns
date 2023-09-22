using DesignPatterns.Structural.Decorator.Interface;

namespace DesignPatterns.Structural.Decorator.Entities
{
    public class PlainTextFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return text;
        }
    }
}
