using DesignPatterns.Creation.AbstractFactory.Entities.Abstract;
using DesignPatterns.Creation.AbstractFactory.Entities.Concrete;
using DesignPatterns.Creation.AbstractFactory.Factory.Interfaces;

namespace DesignPatterns.Creation.AbstractFactory.Factory.Factories
{
    /// <summary>
    /// American Invoice Integration Factory
    /// </summary>
    public class AmericanInvoiceIntegrationFactory : IInvoiceIntegrationFactory
    {
        public IInvoiceCancelation CreateInvoiceCancelation()
        {
            return new AmericanInvoiceCancelation();
        }

        public IInvoiceSender CreateInvoiceSender()
        {
            return new AmericanInvoiceSender();
        }
    }
}
