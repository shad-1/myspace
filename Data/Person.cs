using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Data;

public class Person
{
	[Key]
	[Required]
	public int PersonId { get; set; }
	[Required]
	public string FirstName { get; set; }
	public string? LastName { get; set; }
	public long? PhoneNumber { get; set; }
	public string? Email { get; set; }
	public string? ImageFile { get; set; }
	//public Dictionary<string, string>? Links { get; set; }

	public ICollection<ContactEvent>? ContactEvents { get; set; }
	public ICollection<Tag>? Tags { get; set; }
	public ICollection<Note>? Notes { get; set; }
}

