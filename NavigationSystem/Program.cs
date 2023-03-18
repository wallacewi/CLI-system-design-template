using static NavigationSystem.NavigationMenu;

byte option = SingleMenu(title: "select your option",
                         "Option 0",
                         "Option 1",
                         "Option 2",
                         "Option 3",
                         "Option 4");

Console.WriteLine($"Screen for option {option}");

Console.ReadKey();
