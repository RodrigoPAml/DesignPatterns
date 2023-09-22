using DesignPatterns.Behavioral.ChainsOfResponsability.Interfaces;
using DesignPatterns.Behavioral.ChainsOfResponsability.Request;

namespace DesignPatterns.Behavioral.ChainsOfResponsability.Handlers
{
    // ConcreteHandlers handle requests they are responsible for, and pass on requests they are not responsible for.
    public class ValidateName : Handler
    {
        public override void HandleRequest(InvoiceNoteRequest request)
        {
            if (string.IsNullOrEmpty(request.Name))
                throw new Exception("Invoice name must be informed");

            if (this.successor != null)
                this.successor.HandleRequest(request);
        }
    }
}
