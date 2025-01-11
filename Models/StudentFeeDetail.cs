using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentFeeDetail
{
    public int StudFeeId { get; set; }

    public Guid StudFeeStuGuid { get; set; }

    public int StudFeeCmId { get; set; }

    public DateTime StudFeeDueDate { get; set; }

    public DateTime? StudFeeDate { get; set; }

    public string? StudFeeReceiptNumber { get; set; }

    public int? StudFeeCatId { get; set; }

    public int? StudFeeSecId { get; set; }

    public bool StudFeePaid { get; set; }

    public decimal? StudFeeAmount { get; set; }

    public decimal? StudLateFeeAmount { get; set; }

    public decimal? StudFeeTotalAmount { get; set; }

    public long? StudFeeIsActive { get; set; }

    public int StudFeeMonth { get; set; }

    public int StudFeeYear { get; set; }

    public int StudFeeSchId { get; set; }

    public int StudFeeCmpId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
