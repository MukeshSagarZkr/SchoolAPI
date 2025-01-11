using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentMarksDetail
{
    public int StumarksId { get; set; }

    public Guid StumarksStuGuid { get; set; }

    public int StumarksSubCatId { get; set; }

    public decimal? StumarksQ1Marks1 { get; set; }

    public decimal? StumarksQ1Marks2 { get; set; }

    public decimal? StumarksQ2Marks1 { get; set; }

    public decimal? StumarksQ2Marks2 { get; set; }

    public decimal? StumarksQ3Marks1 { get; set; }

    public decimal? StumarksQ3Marks2 { get; set; }

    public decimal? StumarksFa1 { get; set; }

    public decimal? StumarksFa2 { get; set; }

    public decimal? StumarksFa3 { get; set; }

    public decimal? StumarksFa4 { get; set; }

    public decimal? StumarksSa1 { get; set; }

    public decimal? StumarksSa2 { get; set; }

    public int StumarksCmId { get; set; }

    public int StumarksSecId { get; set; }

    public int StumarksCmpId { get; set; }

    public int StumarksSchId { get; set; }

    public string? StumarksSession { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
