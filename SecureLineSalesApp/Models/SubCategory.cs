using System;
using System.Collections.Generic;

namespace SecureLineSalesApp.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            SubSubCategories = new HashSet<SubSubCategory>();
        }

        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public string? SubCategoryName { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<SubSubCategory> SubSubCategories { get; set; }
    }
}
