using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ClassSmstasksDetail
{
    public int ClstsId { get; set; }

    public int ClstsCmId { get; set; }

    public int ClstsSecId { get; set; }

    public int ClstsTaskId { get; set; }

    public int ClstsCmpId { get; set; }

    public int ClstsSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster ClstsCm { get; set; } = null!;

    public virtual ClassSectionDetail ClstsSec { get; set; } = null!;

    public virtual Smstask ClstsTask { get; set; } = null!;
}
