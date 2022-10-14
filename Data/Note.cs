
using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Data;

public class Note
{
	[Required]
	public int Id { get; set; }
	[Required]
	public string Text { get; set; }
	[Required]
	public DateTime CreatedDate { get; set; }
}

