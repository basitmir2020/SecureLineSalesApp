using SecureLineSalesApp.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureLineSalesApp.Components.Dashboard.Category
{
    internal class CategoryModel : IBaseModel
    {
        public long Id { get; set; }
        public string Slug { get; set; }
        public int Status { get; set; }
        public int IsDeleted { get; set; }
        public DateTime DateTime { get; set; }
    }
}
