using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class AuthorMaster
{
    public int AuthorId { get; set; }

    public string? AuthorName { get; set; }

    public string? AuthorDescription { get; set; }

    public string? AuthorAddress { get; set; }

    public string? AuthorCity { get; set; }

    public string? AuthorState { get; set; }

    public string? AuthorCountry { get; set; }

    public string? AuthorZipcode { get; set; }

    public string? AuthorPhone { get; set; }

    public string? AuthorMobile { get; set; }

    public string? AuthorEmail { get; set; }

    public int? AuthorCityId { get; set; }

    public int? AuthorStateId { get; set; }

    public int AuthorCmpId { get; set; }

    public int AuthorSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BookMaster> BookMasters { get; set; } = new List<BookMaster>();
}
