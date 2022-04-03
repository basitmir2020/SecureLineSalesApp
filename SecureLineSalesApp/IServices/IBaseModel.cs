using System;

namespace SecureLineSalesApp.IServices
{
    public interface IBaseModel
    {
        long Id { get; set; }
        int IsDeleted { get; set; }
    }
}
