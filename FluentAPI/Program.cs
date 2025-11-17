

using FluentAPI;

var config = new EntityConfig().AddTitle("Size").AddValue(1001).GetData();
Console.WriteLine($"Title is: {config.Title}");




Console.ReadKey();
