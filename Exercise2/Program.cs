using Exercise2.Models;

/*
 * Next please convert the property patterns below into extended property patterns.
 */

var localEvent = new Event
{
	Id = 1,
	Date = new DateTimeOffset(2022, 10, 1, 20, 0, 0, new TimeSpan(2, 0, 0)),
	Name = "Generic concert",
	Location = new Location
	{
		Id = 1,
		Name = "Generic location",
		Address = new Address
		{
			City = "Examplecity",
			Country = "Exampleland",
			District = "Exampledistrict",
			Street = "Examplestreet 424"
		},
		Stage = new Stage
		{
			Id = 1,
			Depth = 10.56,
			Width = 30.4,
			Height = 1.8,
			Background = new Background
			{
				Id = 1,
				IsScreen = true,
				Height = 20,
				Width = 30.4
			}
		}
	}
};

Console.WriteLine($@"Your event {localEvent.Name} takes place at {localEvent.Location.Name}, {localEvent.Date:f}.
The address is:\n{localEvent.Location.Address.ToString()}");

switch (localEvent)
{
	case { Acts: { Count: 0 } }:
		Console.WriteLine("There are no acts jet.");

		break;
	case { Acts: { Count: 1 } }:
		Console.WriteLine($"There is only one booked act for now.");

		break;
	default:
		Console.WriteLine($"There are {localEvent.Acts.Count} booked acts.");

		break;
}

Console.WriteLine(localEvent is { Location: { Stage: { Background: { IsScreen: true } } } }
	                  ? "You're lucky there is a screen as background."
	                  : "As a background you should bring a banner or something similar.");