using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpCategoryMaster
{
    public int EmpCatId { get; set; }

    public string? EmpCatName { get; set; }

    public string? EmpCatDesc { get; set; }

    public int EmpCatCmpId { get; set; }

    public int EmpCatSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<EmpCatLeaveDetail> EmpCatLeaveDetails { get; set; } = new List<EmpCatLeaveDetail>();

    public virtual ICollection<EmpCatLeaveDetailsHistory> EmpCatLeaveDetailsHistories { get; set; } = new List<EmpCatLeaveDetailsHistory>();

    public virtual ICollection<EmpLeaveDetail> EmpLeaveDetails { get; set; } = new List<EmpLeaveDetail>();

    public virtual ICollection<EmpLeaveDetailsHistory> EmpLeaveDetailsHistories { get; set; } = new List<EmpLeaveDetailsHistory>();

    public virtual ICollection<EmpMaster> EmpMasters { get; set; } = new List<EmpMaster>();
}
