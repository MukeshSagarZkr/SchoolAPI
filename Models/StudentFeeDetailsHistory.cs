using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentFeeDetailsHistory
{
    public int StudFeehId { get; set; }

    public Guid StudFeehStuGuid { get; set; }

    public string? StudFeehReceiptNumber { get; set; }

    public int StudFeehCmId { get; set; }

    public DateTime StudFeehDueDate { get; set; }

    public DateTime? StudFeehDate { get; set; }

    public bool StudFeeshPaid { get; set; }

    public decimal? StudFeehAmount { get; set; }

    public decimal? StudLateFeehAmount { get; set; }

    public decimal? StudFeehTotalAmount { get; set; }

    public long? StudFeehIsActive { get; set; }

    public int StudFeehMonth { get; set; }

    public int StudFeehYear { get; set; }

    public int? StudFeehCatId { get; set; }

    public int? StudfeehSecId { get; set; }

    public int StudSchId { get; set; }

    public int StudCmpId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
