using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM2
{
    class OrderItem : EntityBase
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
        public OrderItem Retrieve(int orderItemId)
        {

            return new OrderItem();
        }
        public bool Save( OrderItem orderItem)
        {
            var success = true;
            if (orderItem.HasChanges)
            {
                if (orderItem.IsValid)
                {
                    if (orderItem.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
    }
}
