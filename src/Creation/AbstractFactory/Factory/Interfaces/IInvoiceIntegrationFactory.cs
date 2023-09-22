using DesignPatterns.Creation.AbstractFactory.Entities.Abstract;

namespace DesignPatterns.Creation.AbstractFactory.Factory.Interfaces
{
    /// <summary>
    /// Invoice Integration Factory Interface
    /// </summary>
    public interface IInvoiceIntegrationFactory
    {
        public IInvoiceCancelation CreateInvoiceCancelation();

        public IInvoiceSender CreateInvoiceSender();
    }
}
