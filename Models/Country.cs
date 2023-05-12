using System;
using System.Collections.Generic;

namespace demoapiweb.Models;

public partial class Country
{
    public int Countryid { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string CountryTnCode { get; set; } = null!;

    public string TimeZone { get; set; } = null!;

    public string Region { get; set; } = null!;
    public object Countrys { get; internal set; }
}
