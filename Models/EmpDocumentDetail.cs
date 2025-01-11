using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpDocumentDetail
{
    public int EdocId { get; set; }

    public int EdocEmpId { get; set; }

    public string? EdocName { get; set; }

    public string? EdocDescription { get; set; }

    public string? EdocFilename { get; set; }

    public int EdocCmpId { get; set; }

    public int EdocSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual EmpMaster EdocEmp { get; set; } = null!;
}
