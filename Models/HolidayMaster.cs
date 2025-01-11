using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class HolidayMaster
{
    public int HolidayId { get; set; }

    public string? HolidayName { get; set; }

    public string? HolidayDescription { get; set; }

    public int? HolidayTypeId { get; set; }

    public DateTime HolidayFromDate { get; set; }

    public DateTime HolidayToDate { get; set; }

    public int HolidayYear { get; set; }

    public int HolidayCmpId { get; set; }

    public int HolidaySchId { get; set; }

    public bool? HolidayIsStaffApplicable { get; set; }

    public string? HolidaySession { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<HolidayClassDetail> HolidayClassDetails { get; set; } = new List<HolidayClassDetail>();

    public virtual ICollection<HolidayDeptDetail> HolidayDeptDetails { get; set; } = new List<HolidayDeptDetail>();

    public virtual HolidayTypeMaster? HolidayType { get; set; }
}
