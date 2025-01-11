using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class RouteDetail
{
    public int RouteDetailId { get; set; }

    public int RouteDetailRouteId { get; set; }

    public int RouteDetailVehicleId { get; set; }

    public int RouteDetailDriverId { get; set; }

    public int RouteDetailsCmpId { get; set; }

    public int RouteDetailsSchId { get; set; }

    public int? RouteDetailCleanerId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual CleanerMaster? RouteDetailCleaner { get; set; }

    public virtual RouteMaster RouteDetailRoute { get; set; } = null!;

    public virtual VehicleMaster RouteDetailVehicle { get; set; } = null!;

    public virtual ICollection<RouteStopDetail> RouteStopDetails { get; set; } = new List<RouteStopDetail>();
}
