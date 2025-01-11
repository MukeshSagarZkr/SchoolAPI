using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class VehicleExpenseDetail
{
    public int VehexpId { get; set; }

    public int VehexpVehicelId { get; set; }

    public int VehexpTypeId { get; set; }

    public string? VehexpName { get; set; }

    public string? VehexpDesc { get; set; }

    public DateTime? VehexpDate { get; set; }

    public decimal? VehexpAmount { get; set; }

    public int VehexpCmpId { get; set; }

    public int VehexpSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual VehicleMaster VehexpVehicel { get; set; } = null!;
}
