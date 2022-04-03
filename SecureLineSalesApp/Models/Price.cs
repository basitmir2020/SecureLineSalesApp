using System;
using System.Collections.Generic;

namespace SecureLineSalesApp.Models
{
    public partial class Price
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long VarationId { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal ProfitPercent { get; set; }
        public decimal SellingPrice { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual ProductVaration Varation { get; set; } = null!;
    }
}
