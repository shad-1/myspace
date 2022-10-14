using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Data;

public class Tag
{
	[Required]
	public int Id { get; set; }
	[Required]
	public string Text { get; set; }

}

