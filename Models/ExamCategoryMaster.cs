using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ExamCategoryMaster
{
    public int ExamCatId { get; set; }

    public string? ExamCatName { get; set; }

    public string? ExamCatDesc { get; set; }

    public int ExamCatCmpId { get; set; }

    public int ExamCatSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
