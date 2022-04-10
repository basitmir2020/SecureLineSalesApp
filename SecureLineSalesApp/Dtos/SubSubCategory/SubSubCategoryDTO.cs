using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureLineSalesApp.Dtos.SubSubCategory
{
    internal class SubSubCategoryDTO  : CreateSubSubCategoryDTO
    {
        public long Id { get; set; }
        public string? SubCategory { get; set; }
        public string? SubSubCategoryName { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
