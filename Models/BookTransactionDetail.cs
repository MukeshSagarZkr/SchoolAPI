using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class BookTransactionDetail
{
    public int BookTransId { get; set; }

    public int BookTransBookId { get; set; }

    public DateTime BookTransIssueDate { get; set; }

    public int BookTransIssueDays { get; set; }

    public DateTime BookTransReturnDueDate { get; set; }

    public DateTime? BookTransActualReturnDate { get; set; }

    public int? BookTransLateDays { get; set; }

    public decimal? BookTransFinePerDay { get; set; }

    public decimal? BookTransFineAmount { get; set; }

    public bool? BookTransIsFineApplicable { get; set; }

    public bool? BookTransFinePaid { get; set; }

    public int? BookTransTypeId { get; set; }

    public Guid? BookTransStuGuid { get; set; }

    public int? BookTransCmId { get; set; }

    public int? BookTransSecId { get; set; }

    public string? BookTransIssuedTo { get; set; }

    public int BookTransCmpId { get; set; }

    public int BookTransSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual BookMaster BookTransBook { get; set; } = null!;

    public virtual ClassMaster? BookTransCm { get; set; }

    public virtual ClassSectionDetail? BookTransSec { get; set; }

    public virtual StudentMaster? BookTransStu { get; set; }
}
