using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SectionMaster
{
    public int SmId { get; set; }

    public string? SmName { get; set; }

    public int SmCmpId { get; set; }

    public int SmSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<TeacherClassDetail> TeacherClassDetails { get; set; } = new List<TeacherClassDetail>();
}
