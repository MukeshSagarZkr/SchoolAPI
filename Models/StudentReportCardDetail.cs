using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentReportCardDetail
{
    public int RepcardDetailId { get; set; }

    public int RepcardDetailRepcardId { get; set; }

    public string? RepcardDetailSubjectType { get; set; }

    public int? RepcardDetailSubjectId { get; set; }

    public decimal? RepcardDetailQuarterMarks { get; set; }

    public decimal? RepcardDetailFa1Marks { get; set; }

    public decimal? RepcardDetailFa2Marks { get; set; }

    public decimal? RepcardDetailSaMarks { get; set; }

    public string? RepcardDetailGrade { get; set; }

    public string? RepcardDetailFa1Grade { get; set; }

    public string? RepcardDetailFa2Grade { get; set; }

    public string? RepcardDetailSaGrade { get; set; }

    public decimal? RepcardDetailTotalMarks { get; set; }

    public string? RepcardDetailTotalGrade { get; set; }

    public decimal? RepcardDetailTotalMarksQuarter { get; set; }

    public decimal? RepcardDetailTotalMarksFa1 { get; set; }

    public decimal? RepcardDetailTotalMarksFa2 { get; set; }

    public decimal? RepcardDetailTotalMarksSa { get; set; }

    public decimal? RepcardDetailTotalMarksFinal { get; set; }

    public int? RepcardDetailCmpId { get; set; }

    public int? RepcardDetailSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
