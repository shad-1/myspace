
using System;
using System.ComponentModel.DataAnnotations;
using myspace.Enums;

namespace myspace.Data;

public class ContactEvent
{
	[Required]
	public int Id { get; set; }
	public ContactMedium Medium { get; set; }
	public DateTime DateTime { get; set; }
	public EncounterImpression Impression { get; set; }
	public bool NeedsFollowUp { get; set; }
}

