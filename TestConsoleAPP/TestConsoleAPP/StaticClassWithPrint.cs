namespace TestConsoleAPP
{
    public static class StaticClassWithPrint
    {
        public static void Print(string line, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(line);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
