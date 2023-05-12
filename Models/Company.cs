using System;
using System.Collections.Generic;

namespace demoapiweb.Models;

public partial class Company
{
    public int Companyid { get; set; }

    public string Legalname { get; set; } = null!;

    public string Businessname { get; set; } = null!;

    public string ParentCompany { get; set; } = null!;

    public string CompanyStatus { get; set; } = null!;

    public string TimeZone { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? Updated { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdateBy { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
