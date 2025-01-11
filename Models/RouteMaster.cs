using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class RouteMaster
{
    public int RouteId { get; set; }

    public string? RouteCode { get; set; }

    public string? RouteName { get; set; }

    public string? RouteSession { get; set; }

    public int RouteStartLocationId { get; set; }

    public int RouteEndLocationId { get; set; }

    public string? RouteApplicableClasses { get; set; }

    public int RouteCmpId { get; set; }

    public int RouteSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<RouteDetail> RouteDetails { get; set; } = new List<RouteDetail>();

    public virtual LocationMaster RouteEndLocation { get; set; } = null!;

    public virtual LocationMaster RouteStartLocation { get; set; } = null!;

    public virtual ICollection<RouteStopDetail> RouteStopDetails { get; set; } = new List<RouteStopDetail>();
}
