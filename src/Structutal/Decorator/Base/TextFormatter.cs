using DesignPatterns.Structutal.Decorator.Interface;

namespace DesignPatterns.Structutal.Decorator.Base
{
    public abstract class TextFormatter : ITextFormatter
    {
        protected ITextFormatter decoratedFormatter;

        public TextFormatter(ITextFormatter formatter)
        {
            decoratedFormatter = formatter;
        }

        public virtual string Format(string text)
        {
            return decoratedFormatter.Format(text);
        }
    }
}
