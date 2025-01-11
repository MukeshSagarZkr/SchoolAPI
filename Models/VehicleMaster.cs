using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class VehicleMaster
{
    public int VehId { get; set; }

    public string? VehNumber { get; set; }

    public string? VehModel { get; set; }

    public string? VehMake { get; set; }

    public string VehType { get; set; } = null!;

    public string? VehRegistration { get; set; }

    public string? VehInsuranceCompany { get; set; }

    public decimal? VehInsurancePremium { get; set; }

    public int? VehSeatCapacity { get; set; }

    public int VehCmpId { get; set; }

    public int VehSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BillMaster> BillMasters { get; set; } = new List<BillMaster>();

    public virtual ICollection<RouteDetail> RouteDetails { get; set; } = new List<RouteDetail>();

    public virtual ICollection<VehicleExpenseDetail> VehicleExpenseDetails { get; set; } = new List<VehicleExpenseDetail>();
}
