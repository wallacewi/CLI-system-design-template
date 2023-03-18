namespace NavigationSystem;

public static class NavigationMenu
{
    public static byte SingleMenu(string title = "", params string[] options)
    {
        byte selected = 0;
        Console.CursorVisible = false;
        while (true)
        {
            Console.Clear();
            if (title != "")
            {
                Console.WriteLine("+-------------------------------+");
                Console.WriteLine($"|{title.ToUpper(),30} |");
                Console.WriteLine("+-------------------------------+");
            }
            for (byte i = 0; i < options.Length; i++)
            {
                if (i == selected)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($"{options[i],29}    "); // final spaces for indentation animation
                }
                else
                    Console.Write($"{options[i],32} ");
                Console.ResetColor();
                Console.WriteLine("\n");
            }
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("     Use ↑↓ for navigation       ");

            // Key Validation
            var userKey = Console.ReadKey().Key;
            while (true)
            {
                ConsoleKey[] validKeys = new ConsoleKey[]
                {
                    ConsoleKey.DownArrow,
                    ConsoleKey.UpArrow,
                    ConsoleKey.Enter
                };
                if (validKeys.Contains(userKey))
                    break;
                else
                    userKey = Console.ReadKey(true).Key;
            }

            switch (userKey)
            {
                // Key actions
                case ConsoleKey.DownArrow when selected < options.Length - 1: selected++; break;
                case ConsoleKey.UpArrow when selected > 0: selected--; break;
                // Infinity scroll
                case ConsoleKey.DownArrow when selected == options.Length - 1: selected = 0; break;
                case ConsoleKey.UpArrow when selected == 0: selected = (byte)(options.Length - 1); break;
                // Enter select
                case ConsoleKey.Enter: Console.Clear(); return selected;
                default: continue;
            }
        }
    }
}
