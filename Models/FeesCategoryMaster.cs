using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class FeesCategoryMaster
{
    public int FcmId { get; set; }

    public string? FcmCatName { get; set; }

    public string? FcmCatDescription { get; set; }

    public int? FcmCatSchId { get; set; }

    public int? FcmCatCmpId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<FeeClassDetailsHistory> FeeClassDetailsHistories { get; set; } = new List<FeeClassDetailsHistory>();
}
