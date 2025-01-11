using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentGradeDetailsHistory
{
    public int StugradehId { get; set; }

    public int StugradehStugradeId { get; set; }

    public Guid StugradehStuGuid { get; set; }

    public int StugradehScholasticCatId { get; set; }

    public string? StugradehQ1Grade { get; set; }

    public string? StugradehQ2Grade { get; set; }

    public string? StugradehQ3Grade { get; set; }

    public string? StugradehFa1Grade { get; set; }

    public string? StugradehFa2Grade { get; set; }

    public string? StugradehFa3Grade { get; set; }

    public string? StugradehFa4Grade { get; set; }

    public string? StugradehSa1Grade { get; set; }

    public string? StugradehSa2Grade { get; set; }

    public int StugradehCmId { get; set; }

    public int StugradehSecId { get; set; }

    public int StugradehCmpId { get; set; }

    public int StugradehSchId { get; set; }

    public string? StugradehSession { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
