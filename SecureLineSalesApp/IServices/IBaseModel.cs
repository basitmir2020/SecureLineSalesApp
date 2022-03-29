using System;

namespace SecureLineSalesApp.IServices
{
    internal interface IBaseModel
    {
        long Id { get; set; }
        string Slug { get; set; }
        int Status { get; set; }
        int IsDeleted { get; set; }
        DateTime DateTime { get; set; }
    }
}
