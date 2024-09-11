﻿using System.ComponentModel.DataAnnotations;

namespace Contacts.Domain.ValueObjects;
public class Name(string firstName, string lastName)
{
    [Required]
    public string FirstName { get; private set; } = firstName;
    [Required]
    public string LastName { get; private set; } = lastName;

    public override bool Equals(object? obj)
    {
        if (obj is null || GetType() != obj.GetType()) return false;

        Name otherName = (Name)obj;
        return FirstName == otherName.FirstName && LastName == otherName.LastName;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName);
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
