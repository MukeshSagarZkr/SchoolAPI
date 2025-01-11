using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SmstaskHistory
{
    public int StshId { get; set; }

    public int StshTaskId { get; set; }

    public DateTime StshSentDate { get; set; }

    public int StshNotificationReceiverId { get; set; }

    public string? StshNotificationReceiver { get; set; }

    public string? StshSendType { get; set; }

    public string? StshStatus { get; set; }

    public Guid? StshStuGuid { get; set; }

    public int? StshParentId { get; set; }

    public int? StshTeacherId { get; set; }

    public string? StshEmail { get; set; }

    public string? StshPhone { get; set; }

    public string? StshDescription { get; set; }

    public int StshCmpId { get; set; }

    public int StshSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
