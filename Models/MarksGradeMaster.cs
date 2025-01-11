using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class MarksGradeMaster
{
    public int MarksGradeId { get; set; }

    public int? MarksGradeClassId { get; set; }

    public int? MarksGradeMinRange { get; set; }

    public int? MarksGradeMaxRange { get; set; }

    public string? MarksGradeCode { get; set; }

    public decimal? MarksGradePoint { get; set; }

    public int MarksGradeCmpId { get; set; }

    public int MarksGradeSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateOnly ModifiedDate { get; set; }
}
