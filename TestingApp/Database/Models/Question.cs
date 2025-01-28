using System;
using System.Collections.Generic;

namespace TestingApp.Database.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public int TestId { get; set; }

    public string Text { get; set; } = null!;

    public byte[]? Image { get; set; }

    public int Weight { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Test Test { get; set; } = null!;
}
