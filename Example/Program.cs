﻿using Example.Models;

/*
 * This is a simple example to demonstrate some new features of .NET 6 and C# 10.
 * Feel free to add your own or modify the existing code and test out some things.
 * If you feel ready go to the first exercise.
 */

var test = new Test
{
	User = new Person(
		"Max",
		"Mustermann",
		new DateTimeOffset(
			2000,
			1,
			1,
			1,
			1,
			1,
			new TimeSpan(0, 1, 0, 0)),
		Gender.Unknown,
		new AddressWithName
		{
			City = "Musterhausen",
			Street = "Musterstraße 666",
			Zip = "66666",
			FirstName = "Max",
			LastName = "Mustermann"
		})
};

Console.WriteLine(test);
Console.WriteLine(test is { User.Address.Zip: "66666" });