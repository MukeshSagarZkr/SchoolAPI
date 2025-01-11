using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class VendorMaster
{
    public int VendorId { get; set; }

    public string? VendorName { get; set; }

    public string? VendorDesc { get; set; }

    public string? VendorAddress { get; set; }

    public string? VendorCity { get; set; }

    public string? VendorState { get; set; }

    public string? VendorZipcode { get; set; }

    public string? VendorPhone { get; set; }

    public string? VendorMobilePhone { get; set; }

    public int VendorCmpId { get; set; }

    public int VendorSchId { get; set; }

    public string? VendorEmail { get; set; }

    public int? VendorCityId { get; set; }

    public int? VendorStateId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BillMaster> BillMasters { get; set; } = new List<BillMaster>();
}
