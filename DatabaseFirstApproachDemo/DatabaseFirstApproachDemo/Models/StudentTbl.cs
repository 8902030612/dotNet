using System;
using System.Collections.Generic;

namespace DatabaseFirstApproachDemo.Models;

public partial class StudentTbl
{
    public int StdId { get; set; }

    public string? Name { get; set; }

    public string? Course { get; set; }
}
