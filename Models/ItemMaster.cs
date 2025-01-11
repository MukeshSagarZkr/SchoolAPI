using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ItemMaster
{
    public int ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? ItemDescription { get; set; }

    public int? ItemTypeMasterId { get; set; }

    public int ItemCmpId { get; set; }

    public int ItemSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<InventoryMaster> InventoryMasters { get; set; } = new List<InventoryMaster>();

    public virtual ItemTypeMaster? ItemTypeMaster { get; set; }
}
