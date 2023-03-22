namespace NavigationSystem.Utilities;

public static class KeyValidation
{
    public static ConsoleKey VerticalNavigationValidation()
    {
        ConsoleKey userKey = Console.ReadKey(true).Key;
        ConsoleKey[] validKeys = new ConsoleKey[]
        {
                    ConsoleKey.DownArrow,
                    ConsoleKey.UpArrow,
                    ConsoleKey.Enter
        };

        while (!validKeys.Contains(userKey))
            userKey = Console.ReadKey(true).Key;

        return userKey;
    }
}
