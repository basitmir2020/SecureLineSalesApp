using System;
using System.Collections.Generic;

namespace SecureLineSalesApp.Models
{
    public partial class Product
    {
        public Product()
        {
            Prices = new HashSet<Price>();
            ProductVarations = new HashSet<ProductVaration>();
            Stocks = new HashSet<Stock>();
        }

        public long Id { get; set; }
        public long? SubCategoryId { get; set; }
        public string? ProductName { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<ProductVaration> ProductVarations { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
