using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class VisitorMaster
{
    public int VmId { get; set; }

    public string? VmNumber { get; set; }

    public string? VmName { get; set; }

    public DateTime VmDate { get; set; }

    public TimeOnly VmTimeOfArrival { get; set; }

    public TimeOnly VmTimeOfExit { get; set; }

    public string? VmPurpose { get; set; }

    public string? VmContactPerson { get; set; }

    public string? VmAddress { get; set; }

    public string? VmContactNumber { get; set; }

    public int VmCmpId { get; set; }

    public int VmSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
