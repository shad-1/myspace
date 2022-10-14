using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Data;

public class Tag
{
	[Key]
	[Required]
	public int TagId { get; set; }
	[Required]
	public string Text { get; set; }

	public ICollection<Person>? People { get; set; }
	public ICollection<ContactEvent>? ContactEvents { get; set; }

}

