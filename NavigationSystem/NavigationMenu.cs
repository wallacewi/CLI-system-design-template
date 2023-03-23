using static NavigationSystem.Utilities.KeyAction;
using static NavigationSystem.Utilities.KeyValidation;

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

            var userKey = VerticalNavigationValidation();

            selected = VerticalNavigationAction(userKey, selected, options.Length);
        }
    }
}
