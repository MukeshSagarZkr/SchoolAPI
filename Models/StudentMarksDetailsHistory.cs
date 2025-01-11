using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentMarksDetailsHistory
{
    public int StumarkshId { get; set; }

    public int StumarkshStumarksId { get; set; }

    public Guid StumarkshStuGuid { get; set; }

    public int StumarkshSubCatId { get; set; }

    public decimal? StumarkshQ1Marks1 { get; set; }

    public decimal? StumarkshQ1Marks2 { get; set; }

    public decimal? StumarkshQ2Marks1 { get; set; }

    public decimal? StumarkshQ2Marks2 { get; set; }

    public decimal? StumarkshQ3Marks1 { get; set; }

    public decimal? StumarkshQ3Marks2 { get; set; }

    public decimal? StumarkshFa1 { get; set; }

    public decimal? StumarkshFa2 { get; set; }

    public decimal? StumarkshFa3 { get; set; }

    public decimal? StumarkshFa4 { get; set; }

    public decimal? StumarkshSa1 { get; set; }

    public decimal? StumarkshSa2 { get; set; }

    public int StumarkshCmId { get; set; }

    public int StumarkshSecId { get; set; }

    public string? StumarkshSession { get; set; }

    public int StumarkshCmpId { get; set; }

    public int StumarkshSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
