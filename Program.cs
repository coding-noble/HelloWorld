Console.Clear();
Console.CursorVisible = false;

List<ConsoleColor> foregroundColors = new List<ConsoleColor>() {
    ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan,
    ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow,
    ConsoleColor.Gray, ConsoleColor.DarkGray, ConsoleColor.Blue,
    ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Red,
    ConsoleColor.Magenta, ConsoleColor.Yellow
};
string helloWorld = "Hello World";
int currentColorsIndex = 0;
int leftMargin = (Console.WindowWidth - helloWorld.Length) / 2;
int topMargin = Console.WindowHeight / 2;

while (!Console.KeyAvailable)
{
    Console.SetCursorPosition(leftMargin, topMargin); // set the cursor to the center of the console
    Console.ForegroundColor = foregroundColors[currentColorsIndex]; // rotate through the foreground colors
    currentColorsIndex = currentColorsIndex >= foregroundColors.Count - 1 ? 0 : currentColorsIndex + 1; // increment the colors index

    Console.Write(helloWorld); // write Hello World to the console

    Thread.Sleep(250); // wait a 1/4 second before running the code again
}

Console.ResetColor();
Console.Clear();