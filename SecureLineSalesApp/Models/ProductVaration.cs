using System;
using System.Collections.Generic;

namespace SecureLineSalesApp.Models
{
    public partial class ProductVaration
    {
        public ProductVaration()
        {
            Prices = new HashSet<Price>();
            Stocks = new HashSet<Stock>();
        }

        public long Id { get; set; }
        public long ProductId { get; set; }
        public long VarationId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Varation Varation { get; set; } = null!;
        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
