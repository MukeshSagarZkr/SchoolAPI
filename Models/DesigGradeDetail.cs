using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class DesigGradeDetail
{
    public int DesgradeId { get; set; }

    public int DesgradeDesigId { get; set; }

    public int DesgradeGradeId { get; set; }

    public int DesgradeCmpId { get; set; }

    public int DesgradeSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual DesigMaster DesgradeDesig { get; set; } = null!;

    public virtual GradeMaster DesgradeGrade { get; set; } = null!;

    public virtual ICollection<EmpSalaryStructureDetail> EmpSalaryStructureDetails { get; set; } = new List<EmpSalaryStructureDetail>();

    public virtual ICollection<EmpSalaryStructureDetailsHistory> EmpSalaryStructureDetailsHistories { get; set; } = new List<EmpSalaryStructureDetailsHistory>();

    public virtual ICollection<SalaryDesigGradeDetail> SalaryDesigGradeDetails { get; set; } = new List<SalaryDesigGradeDetail>();

    public virtual ICollection<SalaryDesigGradeDetailsHistory> SalaryDesigGradeDetailsHistories { get; set; } = new List<SalaryDesigGradeDetailsHistory>();
}
