using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM2
{
    class Product : EntityBase
    {
        public int ProductId { get; set; }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }

        private string _productName;
        public string ProductName 
        { 
            get
            {
                return _productName.InsertSpace();
            }
            set
            {
                _productName = value;
            }
        
        }


        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public override bool Validate()
        {
            var isValid = true;
            if (!string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

    }
}
