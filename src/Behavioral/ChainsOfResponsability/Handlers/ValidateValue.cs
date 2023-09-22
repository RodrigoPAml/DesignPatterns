using DesignPatterns.Behavioral.ChainsOfResponsability.Interfaces;
using DesignPatterns.Behavioral.ChainsOfResponsability.Request;

namespace DesignPatterns.Behavioral.ChainsOfResponsability.Handlers
{
    // ConcreteHandlers handle requests they are responsible for, and pass on requests they are not responsible for.
    public class ValidateValue : Handler
    {
        public override void HandleRequest(InvoiceNoteRequest request)
        {
            if(request.Value <= 0)
                throw new Exception("Invoice value must be greater than zero");

            if(this.successor != null)
                this.successor.HandleRequest(request);
        }
    }
}
