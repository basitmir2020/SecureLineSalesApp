using System;
using System.Collections.Generic;

namespace SecureLineSalesApp.Dtos.Category
{
    internal class CategoryDTO : CreateCategoryDto
    {
        public long Id { get; set; }
        public string? CategoryName { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
    }


}
