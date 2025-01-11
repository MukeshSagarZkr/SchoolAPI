using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SmtpDetail
{
    public int SmtpDetailId { get; set; }

    public string? SmtpDetailFromAddress { get; set; }

    public string? SmtpDetailGateway { get; set; }

    public string? SmtpDetailUsername { get; set; }

    public string? SmtpDetailPassword { get; set; }

    public string? SmtpDetailSubject { get; set; }

    public string? SmtpDetailBodyText { get; set; }

    public string? SmtpDetailEmailType { get; set; }

    public int SmtpDetailCmpId { get; set; }

    public int SmtpDetailSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
