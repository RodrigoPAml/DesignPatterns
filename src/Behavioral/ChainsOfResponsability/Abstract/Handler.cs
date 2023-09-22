using DesignPatterns.Behavioral.ChainsOfResponsability.Request;

namespace DesignPatterns.Behavioral.ChainsOfResponsability.Interfaces
{
    // The Handler interface defines a method for handling requests.
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(InvoiceNoteRequest request);
    }
}
