using System;
using Microsoft.EntityFrameworkCore;
using myspace.Enums;

namespace myspace.Data;

public class ContactContext: DbContext
{
	public ContactContext(DbContextOptions options): base(options)
	{
	}

	public DbSet<Person>? People { get; set; }
	public DbSet<ContactEvent>? ContactEvents { get; set; }
	public DbSet<ContactTemplate>? ContactTemplates { get; set; }
	public DbSet<Note>? Notes { get; set; }
	public DbSet<Tag>? Tags { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Person>().HasData(
			new Person { PersonId = 1, FirstName = "John", LastName = "Test", PhoneNumber = 8773012998, ImageFile = "test1.jpeg" },
            new Person { PersonId = 2, FirstName = "Charles", LastName = "Test", PhoneNumber = 8783022999, ImageFile = "test2.jpeg" }
            );
		builder.Entity<Tag>().HasData(
			new Tag { TagId = 1, Text = "School" },
			new Tag { TagId = 2, Text = "Work" }
			);
		builder.Entity<Note>().HasData(
			new Note { NoteId = 1, Text = "John is awesome!", CreatedDate = DateTime.Now, PersonId = 1 }
			);
		builder.Entity<ContactEvent>().HasData(
			new ContactEvent { ContactEventId = 1, DateTimeOccurred = DateTime.Now - new TimeSpan(24, 0, 0), Impression = EncounterImpression.Positive, Medium = ContactMedium.InPerson, NeedsFollowUp = false, Title = "Work social" }
			);
		builder.Entity<ContactTemplate>().HasData(
			new ContactTemplate { ContactTemplateId = 1, Greeting = "Hey {0}!", BodyText = "It's been too long. How are things for you? I would love to hear an update about your family, too. \n\nBest, {1}"}
			);
	}
}

