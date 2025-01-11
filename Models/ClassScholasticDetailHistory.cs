using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ClassScholasticDetailHistory
{
    public int ClscohHistId { get; set; }

    public int ClscohHistCmId { get; set; }

    public int ClscohHistScholasticId { get; set; }

    public string? ClscohHistSession { get; set; }

    public int ClscohHistCmpId { get; set; }

    public int ClscohHistSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
