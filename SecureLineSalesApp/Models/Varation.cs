using System;
using System.Collections.Generic;

namespace SecureLineSalesApp.Models
{
    public partial class Varation
    {
        public Varation()
        {
            ProductVarations = new HashSet<ProductVaration>();
        }

        public long Id { get; set; }
        public string VariationName { get; set; } = null!;
        public string VariationValue { get; set; } = null!;
        public int? IsDeleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ICollection<ProductVaration> ProductVarations { get; set; }
    }
}
