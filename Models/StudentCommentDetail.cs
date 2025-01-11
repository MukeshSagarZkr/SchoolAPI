using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentCommentDetail
{
    public int StucommentId { get; set; }

    public Guid StucommentStuGuid { get; set; }

    public int StucommentCmId { get; set; }

    public int StucommentSecId { get; set; }

    public string? StucommentSession { get; set; }

    public string? StucommentQ1Desc { get; set; }

    public string? StucommentQ2Desc { get; set; }

    public string? StucommentQ3Desc { get; set; }

    public string? StucommentSa1Desc { get; set; }

    public string? StucommentSa2Desc { get; set; }

    public string? StucommentFinalDesc { get; set; }

    public int StucommentCmpId { get; set; }

    public int StucommentSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
