namespace DesignPatterns.Creation.AbstractFactory.Entities.Abstract
{
    /// <summary>
    /// Abstract Invoice Cancelation Entity
    /// </summary>
    public interface IInvoiceCancelation
    {
        void CancelInvoiceNote(long invoiceNoteId);
    }
}
