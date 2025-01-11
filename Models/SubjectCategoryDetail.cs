using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SubjectCategoryDetail
{
    public int SubcatId { get; set; }

    public string? SubcatName { get; set; }

    public string? SubcatDesc { get; set; }

    public string? SubcatSession { get; set; }

    public int? SubcatParentId { get; set; }

    public int? SubcatSubjectId { get; set; }

    public int SubcatCmpId { get; set; }

    public int SubcatSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
