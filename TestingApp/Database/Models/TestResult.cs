using System;
using System.Collections.Generic;

namespace TestingApp.Database.Models;

public partial class TestResult
{
    public int Id { get; set; }

    public int TestId { get; set; }

    public int StudentId { get; set; }

    public decimal Score { get; set; }

    public DateTime DateTaken { get; set; }

    public int TimeSpent { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Test Test { get; set; } = null!;
}
