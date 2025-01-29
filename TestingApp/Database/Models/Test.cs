using System;
using System.Collections.Generic;

namespace TestingApp.Database.Models;

public partial class Test
{
    public int TestId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<TestResult> TestResults { get; set; } = new List<TestResult>();
}
