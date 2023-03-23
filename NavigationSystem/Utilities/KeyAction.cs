namespace NavigationSystem.Utilities;

public static class KeyAction
{
    public static byte VerticalNavigationAction(ConsoleKey key, byte selected, int options)
    {
        switch (key)
        {
            // Key actions
            case ConsoleKey.DownArrow when selected < options - 1: selected++; break;
            case ConsoleKey.UpArrow when selected > 0: selected--; break;
            // Infinity scroll
            case ConsoleKey.DownArrow when selected == options - 1: selected = 0; break;
            case ConsoleKey.UpArrow when selected == 0: selected = (byte)(options - 1); break;
            // Enter select
            case ConsoleKey.Enter: Console.Clear(); return selected;
        }
        return selected;
    }
}
