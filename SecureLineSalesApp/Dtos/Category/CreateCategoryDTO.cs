using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureLineSalesApp.Dtos.Category
{
    internal class CreateCategoryDto : UpdateCategoryDTO
    {
        internal int IsDeleted { get; set; }
    }
}
