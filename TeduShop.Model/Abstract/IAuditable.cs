using System;

namespace TeduShop.Model.Models
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string Updatedby { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}