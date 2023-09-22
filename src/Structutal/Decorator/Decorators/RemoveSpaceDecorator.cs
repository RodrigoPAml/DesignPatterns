using DesignPatterns.Structutal.Decorator.Base;
using DesignPatterns.Structutal.Decorator.Interface;

namespace DesignPatterns.Structutal.Decorator.Decorators
{
    public class RemoveSpaceDecorator : TextFormatter
    {
        public RemoveSpaceDecorator(ITextFormatter formatter) : base(formatter)
        {
        }

        public override string Format(string text)
        {
            return base.Format(text).Replace(" ", "");
        }
    }
}
