// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");

DateTime christmasDate = new(DateTime.Now.Year, 12, 25);
TimeSpan daysToChristmas = christmasDate.Subtract(DateTime.Today);

Console.WriteLine($"There are {daysToChristmas.Days} days until Christmas");