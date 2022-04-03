using System;
using System.Collections.Generic;
using SecureLineSalesApp.IServices;

namespace SecureLineSalesApp.Models
{
    public partial class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }

        public long Id { get; set; }
        public string? CategoryName { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
