using System;
using System.Collections.Generic;

namespace arth_backend;

public partial class User
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public int? Age { get; set; }

    public string? Login { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateTime? DateOfBirthday { get; set; }

    public string? ProfilePictureUrl { get; set; }

    public DateTime? CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }
}
