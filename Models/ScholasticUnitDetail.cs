using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ScholasticUnitDetail
{
    public int ScohudScholasticId { get; set; }

    public int ScohudUnitId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ScholasticMaster ScohudScholastic { get; set; } = null!;

    public virtual ExamUnitMaster ScohudUnit { get; set; } = null!;
}
