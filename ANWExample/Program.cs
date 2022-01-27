using ANWExample.Models;

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
        new Address
        {
            City = "Musterhausen",
            Street = "Musterstraße 666",
            Zip = "66666"
        })
};

Console.WriteLine(test);
Console.WriteLine(test is { User.Address.Zip: "66666" });