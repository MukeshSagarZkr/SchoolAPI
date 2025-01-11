using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ClassScholasticDetail
{
    public int ClscohCmId { get; set; }

    public int ClscohScholasticId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster ClscohCm { get; set; } = null!;

    public virtual ScholasticMaster ClscohScholastic { get; set; } = null!;
}
