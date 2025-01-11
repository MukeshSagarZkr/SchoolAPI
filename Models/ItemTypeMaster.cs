using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ItemTypeMaster
{
    public int ItemTypeId { get; set; }

    public string? ItemTypeName { get; set; }

    public string? ItemTypeDescription { get; set; }

    public int ItemTypeCmpId { get; set; }

    public int ItemTypeSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<ItemMaster> ItemMasters { get; set; } = new List<ItemMaster>();
}
