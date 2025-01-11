using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class UserDetail
{
    public int UserId { get; set; }

    public string UserUsername { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string UserFirstName { get; set; } = null!;

    public string UserLastName { get; set; } = null!;

    public string UserEmailAddress { get; set; } = null!;

    public string? UserDesignation { get; set; }

    public int UserRoleId { get; set; }

    public bool? UserIsSuperUser { get; set; }

    public int UserCmpId { get; set; }

    public int UserSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual RoleMaster UserRole { get; set; } = null!;
}
