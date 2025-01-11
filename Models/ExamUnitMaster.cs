using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ExamUnitMaster
{
    public int ExamUnitId { get; set; }

    public string? ExamUnitName { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<ScholasticUnitDetail> ScholasticUnitDetails { get; set; } = new List<ScholasticUnitDetail>();
}
