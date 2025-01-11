using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentAchievement
{
    public int StudAchId { get; set; }

    public Guid StudStuGuid { get; set; }

    public string? StudAchSchool { get; set; }

    public string? StudAchSession { get; set; }

    public string? StudAchDescription { get; set; }

    public int StudSchId { get; set; }

    public int StudCmpId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
