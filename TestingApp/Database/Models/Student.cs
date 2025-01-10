using System;
using System.Collections.Generic;

namespace TestingApp.Database.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string StudentName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
