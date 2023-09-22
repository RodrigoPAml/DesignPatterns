using DesignPatterns.Structutal.Decorator.Interface;

namespace DesignPatterns.Structutal.Decorator.Entities
{
    public class PlainTextFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return text;
        }
    }
}
