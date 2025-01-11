using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ScholasticMaster
{
    public int ScholasticId { get; set; }

    public string? ScholasticName { get; set; }

    public string? ScholasticDesc { get; set; }

    public int? ScholasticParentId { get; set; }

    public int? ScholasticSubjectId { get; set; }

    public int ScholasticCmpId { get; set; }

    public int ScholasticSchId { get; set; }

    public string? ScholasticSession { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<ClassScholasticDetail> ClassScholasticDetails { get; set; } = new List<ClassScholasticDetail>();

    public virtual ICollection<ScholasticUnitDetail> ScholasticUnitDetails { get; set; } = new List<ScholasticUnitDetail>();
}
