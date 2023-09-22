using DesignPatterns.Creation.AbstractFactory.Factory.Interfaces;

namespace DesignPatterns.Creation.AbstractFactory
{
    public class InvoiceIntegration
    {
        private IInvoiceIntegrationFactory _invoiceIntegrationFactory;

        public InvoiceIntegration(IInvoiceIntegrationFactory invoiceIntegrationFactory)
        {
            _invoiceIntegrationFactory = invoiceIntegrationFactory;
        }

        public void Send(long invoiceNoteId)
        {
            var sender = _invoiceIntegrationFactory.CreateInvoiceSender();
            
            sender.SendInvoiceNote(invoiceNoteId);
        }

        public void Cancel(long invoiceNoteId)
        {
            var cancelation = _invoiceIntegrationFactory.CreateInvoiceCancelation();

            cancelation.CancelInvoiceNote(invoiceNoteId);
        }
    }
}