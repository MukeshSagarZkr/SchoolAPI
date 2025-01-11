using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class BillMaster
{
    public int BillId { get; set; }

    public string BillNumber { get; set; } = null!;

    public DateTime BillDate { get; set; }

    public DateTime? BillDueDate { get; set; }

    public string? BillDesc { get; set; }

    public int BillVendorId { get; set; }

    public decimal? BillAmount { get; set; }

    public decimal? BillTaxAmount { get; set; }

    public decimal? BillTotalAmount { get; set; }

    public int BillCmpId { get; set; }

    public int BillSchId { get; set; }

    public int? BillStatus { get; set; }

    public int? BillVehicleId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual VehicleMaster? BillVehicle { get; set; }

    public virtual VendorMaster BillVendor { get; set; } = null!;
}
