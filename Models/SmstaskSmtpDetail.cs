using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SmstaskSmtpDetail
{
    public int StssmtpDetailId { get; set; }

    public string? StssmtpDetailFromAddress { get; set; }

    public string? StssmtpDetailGateway { get; set; }

    public string? StssmtpDetailUsername { get; set; }

    public string? StssmtpDetailPassword { get; set; }

    public string? StssmtpDetailSubject { get; set; }

    public string? StssmtpDetailBodyText { get; set; }

    public int? StssmtpTaskId { get; set; }

    public int StssmtpDetailCmpId { get; set; }

    public int StssmtpDetailSchId { get; set; }

    public string? StssmtpDetailMessageSubject { get; set; }

    public string? StssmtpDetailMessageBody { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual Smstask? StssmtpTask { get; set; }
}
