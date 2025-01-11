using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class CleanerMaster
{
    public int CleanerId { get; set; }

    public string? CleanerName { get; set; }

    public string? CleanerFatherName { get; set; }

    public string? CleanerDesc { get; set; }

    public int CleanerCmpId { get; set; }

    public int CleanerSchId { get; set; }

    public string? CleanerImage { get; set; }

    public string? CleanerIdImage { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<RouteDetail> RouteDetails { get; set; } = new List<RouteDetail>();
}
