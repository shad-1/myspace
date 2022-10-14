using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Data;

public class ContactTemplate
{
	[Key]
	[Required]
	public int ContactTemplateId { get; set; }
	[Required]
	public string Greeting { get; set; }
	[Required]
	public string BodyText { get; set; }

	public ICollection<ContactEvent>? ContactEvents { get; set; }
}

