using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentGradeDetail
{
    public int StugradeId { get; set; }

    public Guid StugradeStuGuid { get; set; }

    public int StugradeScholasticCatId { get; set; }

    public string? StugradeQ1Grade { get; set; }

    public string? StugradeQ2Grade { get; set; }

    public string? StugradeQ3Grade { get; set; }

    public string? StugradeFa1Grade { get; set; }

    public string? StugradeFa2Grade { get; set; }

    public string? StugradeFa3Grade { get; set; }

    public string? StugradeFa4Grade { get; set; }

    public string? StugradeSa1Grade { get; set; }

    public string? StugradeSa2Grade { get; set; }

    public int StugradeCmId { get; set; }

    public int StugradeSecId { get; set; }

    public int StugradeCmpId { get; set; }

    public int StugradeSchId { get; set; }

    public string? StugradeSession { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
