
using System;
using System.ComponentModel.DataAnnotations;
using myspace.Enums;

namespace myspace.Data;

public class ContactEvent
{
	[Key]
	[Required]
	public int ContactEventId { get; set; }
	public string? Title { get; set; }
	public ContactMedium Medium { get; set; }
	public DateTime DateTimeOccurred { get; set; }
	public EncounterImpression Impression { get; set; }
	public bool NeedsFollowUp { get; set; }

	public ICollection<Person>? People { get; set; }
	public ICollection<Tag>? Tags { get; set; }
	public int? ContactTemplateID { get; set; }
	public ICollection<Note>? Notes { get; set; }
}

