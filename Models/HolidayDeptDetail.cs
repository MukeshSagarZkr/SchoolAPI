using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class HolidayDeptDetail
{
    public int HdeptHolidayId { get; set; }

    public int HdeptDeptId { get; set; }

    public int HdeptCmpId { get; set; }

    public int HdeptSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual DeptMaster HdeptDept { get; set; } = null!;

    public virtual HolidayMaster HdeptHoliday { get; set; } = null!;
}
