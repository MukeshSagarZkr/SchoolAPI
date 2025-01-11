using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class NotificationReceiverMaster
{
    public int NotificationReceiverId { get; set; }

    public string? NotificationReceiverName { get; set; }

    public string? NotificationReceiverDesc { get; set; }

    public int NotificationReceiverCmpId { get; set; }

    public int? NotificationReceiverSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<Smstask> Smstasks { get; set; } = new List<Smstask>();
}
