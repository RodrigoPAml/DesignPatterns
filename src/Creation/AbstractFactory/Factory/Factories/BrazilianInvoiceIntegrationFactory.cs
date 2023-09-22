using DesignPatterns.Creation.AbstractFactory.Entities.Abstract;
using DesignPatterns.Creation.AbstractFactory.Entities.Concrete;
using DesignPatterns.Creation.AbstractFactory.Factory.Interfaces;

namespace DesignPatterns.Creation.AbstractFactory.Factory.Factories
{
    /// <summary>
    /// Brazilian Invoice Integration Factory
    /// </summary>
    public class BrazilianInvoiceIntegrationFactory : IInvoiceIntegrationFactory
    {
        public IInvoiceCancelation CreateInvoiceCancelation()
        {
            return new BrazilianInvoiceCancelation();
        }

        public IInvoiceSender CreateInvoiceSender()
        {
            return new AmericanInvoiceSender();
        }
    }
}
