using System;
using System.Collections.Generic;

namespace SecureLineSalesApp.Models
{
    public partial class SubSubCategory
    {
        public long Id { get; set; }
        public long? SubCategoryId { get; set; }
        public string? SubSubCategoryName { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual SubCategory? SubCategory { get; set; }
    }
}
