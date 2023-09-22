using DesignPatterns.Creation.AbstractFactory.Entities.Abstract;

namespace DesignPatterns.Creation.AbstractFactory.Entities.Concrete
{
    /// <summary>
    /// Concreate Invoice Cancelation
    /// </summary>
    public class BrazilianInvoiceCancelation : IInvoiceCancelation
    {
        public void CancelInvoiceNote(long invoiceNoteId)
        {
            Console.WriteLine($"Canceling invoice note with id {invoiceNoteId} to brazilian government");
        }
    }
}
