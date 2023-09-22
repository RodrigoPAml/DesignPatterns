namespace DesignPatterns.Creation.AbstractFactory.Entities.Abstract
{
    /// <summary>
    /// Abstract Invoice Sender Entity
    /// </summary>
    public interface IInvoiceSender
    {
        void SendInvoiceNote(long invoiceNoteId);
    }
}
