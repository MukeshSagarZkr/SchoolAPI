using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentReportCardDetailsHistory
{
    public int RepcardhDetailId { get; set; }

    public int RepcardhDetailRepcardId { get; set; }

    public string? RepcardhDetailSubjectType { get; set; }

    public int? RepcardhDetailSubjectId { get; set; }

    public decimal? RepcardhDetailQuarterMarks { get; set; }

    public decimal? RepcardhDetailFa1Marks { get; set; }

    public decimal? RepcardhDetailFa2Marks { get; set; }

    public decimal? RepcardhDetailSaMarks { get; set; }

    public string? RepcardhDetailGrade { get; set; }

    public string? RepcardhDetailFa1Grade { get; set; }

    public string? RepcardhDetailFa2Grade { get; set; }

    public string? RepcardhDetailSaGrade { get; set; }

    public decimal? RepcardhDetailTotalMarks { get; set; }

    public string? RepcardhDetailTotalGrade { get; set; }

    public decimal? RepcardhDetailTotalMarksQuarter { get; set; }

    public decimal? RepcardhDetailTotalMarksFa1 { get; set; }

    public decimal? RepcardhDetailTotalMarksFa2 { get; set; }

    public decimal? RepcardhDetailTotalMarksSa { get; set; }

    public decimal? RepcardhDetailTotalMarksFinal { get; set; }

    public int? RepcardhDetailCmpId { get; set; }

    public int? RepcardhDetailSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
