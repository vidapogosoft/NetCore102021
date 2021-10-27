using MediatR;
using System.Collections.Generic;
using static Catalag.Common.Enums;

namespace Catalog.Services.EventHandlers.Commands
{
    public class ProductInStockUpdateStockCommand: INotification
    {
        public IEnumerable<ProductInStockUpdateItem> Items { get; set; } = new List<ProductInStockUpdateItem>();
    }

    public class ProductInStockUpdateItem
    {
        public int ProductId { get; set; }
        public int Stock { get; set; }

        public ProductInStockAction Action { get; set; }
    }

}
