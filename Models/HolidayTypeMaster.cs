using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class HolidayTypeMaster
{
    public int HolidayTypeId { get; set; }

    public string? HolidayTypeName { get; set; }

    public string? HolidayTypeDescription { get; set; }

    public int HolidayTypeCmpId { get; set; }

    public int HolidayTypeSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<HolidayMaster> HolidayMasters { get; set; } = new List<HolidayMaster>();
}
