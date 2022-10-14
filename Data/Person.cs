using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Data;

public class Person
{
	[Required]
	public int Id { get; set; }
	[Required]
	public string FirstName { get; set; }
	public string? LastName { get; set; }
	public string? PhoneNumber { get; set; }
	public string? Email { get; set; }
	public Dictionary<string, string>? Links { get; set; }
}

