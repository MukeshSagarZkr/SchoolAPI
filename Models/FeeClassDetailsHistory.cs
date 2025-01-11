using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class FeeClassDetailsHistory
{
    public int FcdhId { get; set; }

    public int FcdhCmId { get; set; }

    public int FcdhFeeCatId { get; set; }

    public string? FcdhSession { get; set; }

    public DateTime FcdhFromDate { get; set; }

    public DateTime FcdhToDate { get; set; }

    public decimal? FcdhAmount { get; set; }

    public int? FcdhSchId { get; set; }

    public int? FcdhCmpId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster FcdhCm { get; set; } = null!;

    public virtual FeesCategoryMaster FcdhFeeCat { get; set; } = null!;
}
