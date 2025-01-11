using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ItemLocationMaster
{
    public int ItemLocationId { get; set; }

    public string? ItemLocationName { get; set; }

    public string? ItemLocationDescription { get; set; }

    public string? ItemLocationBuilding { get; set; }

    public string? ItemLocationFloor { get; set; }

    public int? ItemLocationNumber { get; set; }

    public int? ItemLocationCapacity { get; set; }

    public int ItemLocationCmpId { get; set; }

    public int ItemLocationSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<InventoryMaster> InventoryMasters { get; set; } = new List<InventoryMaster>();
}
