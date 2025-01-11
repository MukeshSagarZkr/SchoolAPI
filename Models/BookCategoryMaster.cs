using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class BookCategoryMaster
{
    public int BookCatId { get; set; }

    public string? BookCatName { get; set; }

    public string? BookCatDescription { get; set; }

    public int BookCatCmpId { get; set; }

    public int BookCatSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateOnly CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BookMaster> BookMasters { get; set; } = new List<BookMaster>();
}
