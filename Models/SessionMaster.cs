using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SessionMaster
{
    public int SessionId { get; set; }

    public string? SessionValue { get; set; }

    public string? SessionDescription { get; set; }

    public int SessionCmpId { get; set; }

    public int SessionSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
