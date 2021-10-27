using System;

namespace Catalog.Services.EventHandlers.Exceptions
{
    public class ProductInStockUpdateStockCommandException: Exception
    {
        public ProductInStockUpdateStockCommandException(string message) : base(message) { }
    }
}
