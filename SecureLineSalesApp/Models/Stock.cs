using System;
using System.Collections.Generic;

namespace SecureLineSalesApp.Models
{
    public partial class Stock
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long VarationId { get; set; }
        public long Quantity { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual ProductVaration Varation { get; set; } = null!;
    }
}
