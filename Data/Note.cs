
using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Data;

public class Note
{
	[Key]
	[Required]
	public int NoteId { get; set; }
	[Required]
	public string Text { get; set; }
	[Required]
	public DateTime CreatedDate { get; set; }

	public int? PersonId { get; set; }
	public int? ContactEventID { get; set; }
}

