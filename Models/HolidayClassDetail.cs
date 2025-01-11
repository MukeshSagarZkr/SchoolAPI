using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class HolidayClassDetail
{
    public int HcldHolidayId { get; set; }

    public int HcldCmId { get; set; }

    public int HcldSecId { get; set; }

    public int HcldCmpId { get; set; }

    public int HcldSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster HcldCm { get; set; } = null!;

    public virtual HolidayMaster HcldHoliday { get; set; } = null!;

    public virtual ClassSectionDetail HcldSec { get; set; } = null!;
}
