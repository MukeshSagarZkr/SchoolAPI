using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class Smstask
{
    public int StsId { get; set; }

    public string? StsName { get; set; }

    public string? StsDescription { get; set; }

    public string StsNotificationSendEmail { get; set; } = null!;

    public string StsNotificationSendSms { get; set; } = null!;

    public int StsNotificationReceieverId { get; set; }

    public string StsRepeatSchedule { get; set; } = null!;

    public int StsStatusId { get; set; }

    public int StsCmpId { get; set; }

    public int StsSchId { get; set; }

    public bool? StsIsReadonly { get; set; }

    public int? StsLastRunStatusId { get; set; }

    public DateTime? StsLastRunDate { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<ClassSmstasksDetail> ClassSmstasksDetails { get; set; } = new List<ClassSmstasksDetail>();

    public virtual ICollection<SmstaskSchedule> SmstaskSchedules { get; set; } = new List<SmstaskSchedule>();

    public virtual ICollection<SmstaskSmtpDetail> SmstaskSmtpDetails { get; set; } = new List<SmstaskSmtpDetail>();

    public virtual NotificationReceiverMaster StsNotificationReceiever { get; set; } = null!;
}
