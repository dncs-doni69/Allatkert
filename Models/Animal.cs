using System;

namespace Animals.Models;

public class Animal
{
    public string Name { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public DateTimeOffset? DateOfBirth { get; set; }

    public string DateOfBirthDisplay =>
        DateOfBirth.HasValue ? DateOfBirth.Value.ToString("yyyy-MM-dd") : string.Empty;
}
