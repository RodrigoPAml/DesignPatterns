using DesignPatterns.Creation.AbstractFactory.Entities.Abstract;

namespace DesignPatterns.Creation.AbstractFactory.Entities.Concrete
{
    /// <summary>
    /// Concrete Invoice Cancelation
    /// </summary>
    public class AmericanInvoiceCancelation : IInvoiceCancelation
    {
        public void CancelInvoiceNote(long invoiceNoteId)
        {
            Console.WriteLine($"Canceling invoice note with id {invoiceNoteId} to american government");
        }
    }
}
