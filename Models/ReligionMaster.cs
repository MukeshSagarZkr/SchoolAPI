using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ReligionMaster
{
    public int ReligionId { get; set; }

    public string? ReligionName { get; set; }

    public int RegCmpId { get; set; }

    public int RegSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
