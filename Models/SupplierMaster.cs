using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SupplierMaster
{
    public int SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? SupplierDescription { get; set; }

    public string? SupplierAddress { get; set; }

    public string? SupplierCity { get; set; }

    public string? SupplierState { get; set; }

    public string? SupplierCountry { get; set; }

    public string? SupplierZipcode { get; set; }

    public string? SupplierPhone { get; set; }

    public string? SupplierMobile { get; set; }

    public string? SupplierEmail { get; set; }

    public int? SupplierCityId { get; set; }

    public int? SupplierStateId { get; set; }

    public int SupplierCmpId { get; set; }

    public int SupplierSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BookMaster> BookMasters { get; set; } = new List<BookMaster>();
}
