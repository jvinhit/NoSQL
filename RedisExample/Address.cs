using System;

public class Address
{
	public string Street { get; set; }
	public int PostCode { get; set; }
	public string Town { get; set; }
	public string Country { get; set; }

	public override string ToString()
	{
		return string.Format(
			"Adress({0}, {1}, {2}, {3})",
			Street, PostCode, Town, Country);
	}
}
