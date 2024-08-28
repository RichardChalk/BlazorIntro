using System;
using System.Collections.Generic;

namespace BlazorIntro.Models;

public partial class EmployeeNameAndTitle
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Title { get; set; }

    public string? Address { get; set; }
}
