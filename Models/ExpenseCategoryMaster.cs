using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ExpenseCategoryMaster
{
    public int ExpCatId { get; set; }

    public string? ExpCatName { get; set; }

    public string? ExpCatDesc { get; set; }

    public int ExpCatCmpId { get; set; }

    public int ExpCatSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual ICollection<VoucherMaster> VoucherMasters { get; set; } = new List<VoucherMaster>();
}
