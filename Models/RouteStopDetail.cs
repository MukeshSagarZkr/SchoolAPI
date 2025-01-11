using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class RouteStopDetail
{
    public int RouteStopId { get; set; }

    public int RouteStopRouteDetailId { get; set; }

    public int RouteStopRouteId { get; set; }

    public int RouteStopLocationId { get; set; }

    public int RouteStopNumber { get; set; }

    public string RouteStopPickupTime { get; set; } = null!;

    public string RouteStopDropTime { get; set; } = null!;

    public decimal? RouteStopOneWayMonthlyFee { get; set; }

    public decimal? RouteStopTwoWayMonthlyFee { get; set; }

    public int? RouteStopCmpId { get; set; }

    public int? RouteStopSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual LocationMaster RouteStopLocation { get; set; } = null!;

    public virtual RouteMaster RouteStopRoute { get; set; } = null!;

    public virtual RouteDetail RouteStopRouteDetail { get; set; } = null!;
}
