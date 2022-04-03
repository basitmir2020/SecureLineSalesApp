using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureLineSalesApp.Dtos.SubCategory
{
    internal class SubCategoryDTO : CreateSubCategoryDTO
    {
        public long Id { get; set; }
        public string? Category { get; set; }
        public string? SubCategoryName { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
