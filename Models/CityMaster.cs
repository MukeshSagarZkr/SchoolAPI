using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class CityMaster
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public int CityStateId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
