using System;

public class Person
{
	public Guid ID { get; set; }
	public string Name { get; set; }
	public Gender Gender { get; set; }
	public string Phone { get; set; }
	public Address Address { get; set; }
	public string Email { get; set; }
	public string Site { get; set; }
	public DateTime DateAdded { get; set; }

	public override string ToString()
	{
		return string.Format(
			"Person(\n" +
			"  ID: {0}\n" +
			"  Name: {1}\n" +
			"  Gender: {2}\n" +
			"  Phone: {3}\n" +
			"  Address: {4}\n" +
			"  Email: {5}\n" +
			"  Site: {6}\n" +
			"  Date Added: {7}\n" +
			")",
			ID, Name, Gender, Phone, Address, Email, Site, DateAdded);
	}
}
