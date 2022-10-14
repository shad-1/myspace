using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Data;

public class ContactTemplate
{
	[Required]
	public int Id { get; set; }
	[Required]
	public string Greeting { get; set; }
	[Required]
	public string BodyText { get; set; }
}

