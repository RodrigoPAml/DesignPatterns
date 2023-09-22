using DesignPatterns.Creation.AbstractFactory.Entities.Abstract;

namespace DesignPatterns.Creation.AbstractFactory.Entities.Concrete
{
    /// <summary>
    /// Concreate Invoice Sender 
    /// </summary>
    public class BrazilianInvoiceSender : IInvoiceSender
    {
        public void SendInvoiceNote(long invoiceNoteId)
        {
            Console.WriteLine($"Sending invoice note with id {invoiceNoteId} to brazilian government");
        }
    }
}
