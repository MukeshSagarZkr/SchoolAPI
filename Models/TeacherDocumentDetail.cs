using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TeacherDocumentDetail
{
    public int TdocId { get; set; }

    public int TdocTeacherId { get; set; }

    public string? TdocName { get; set; }

    public string? TdocDescription { get; set; }

    public string? TdocFilename { get; set; }

    public int? TdocCmpId { get; set; }

    public int? TdocSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual TeacherMaster TdocTeacher { get; set; } = null!;
}
