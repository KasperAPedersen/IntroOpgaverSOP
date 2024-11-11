// See https://aka.ms/new-console-template for more information
using IntroOpgaver2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.CursorVisible = false;

CMenu menu = new();
menu.menuOptions = CreateMenuOptions();
menu.Display();

while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();

    switch(key.Key)
    {
        case ConsoleKey.Enter:
            menu.menuOptions[menu.menuIndex].Action();
            menu.Display();
            break;
        case ConsoleKey.DownArrow:
            menu.UpdateIndex(menu.menuIndex + 1);
            break;
        case ConsoleKey.UpArrow:
            menu.UpdateIndex(menu.menuIndex - 1);
            break;
        default:
            break;
    }
    
    /*printMenu();
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.D1:
            Assignment1.Run();
            break;
        case ConsoleKey.D2:
            Assignment2.Run();
            break;
        case ConsoleKey.D3:
            Assignment3.Run();
            break;
        case ConsoleKey.D4:
            Assignment4.Run();
            break;
        case ConsoleKey.D5:
            Assignment5.Run();
            break;
        case ConsoleKey.D6:
            Assignment6.Run();
            break;
        case ConsoleKey.D7:
            Assignment7.Run();
            break;
        case ConsoleKey.Q:
            keepRunning = false;
            break;
    }*/
}

static List<CMenu.MenuOption> CreateMenuOptions()
{
    return
    [
        new ("Exit", () => { Environment.Exit(0); }),
        new ("Opg. 1 - Matematik", Assignment1.Run),
        new ("Opg. 2 - Loop med summering", Assignment2.Run),
        new ("Opg. 3 - Beregne fakultetet af et tal", Assignment3.Run),
        new ("Opg. 4 - Læs og skriv til en fil", Assignment4.Run),
        new ("Opg. 5 - JSON string editor og syntax checker", Assignment5.Run),
        new ("Opg. 6 - Email checker - med loop, if, regler", Assignment6.Run),
        new ("Opg. 7 - Email checker - regulær udtryk", Assignment7.Run)
    ];
}

static void printMenu()
{
    Console.Title = ";)";
    
    string[] menuLines = [ "[1] ", "[2] ", "[3] ", "[4] ", "[5] ", "[6] ", "[7] ", "Tast et tal 1 - 7 eller q for at afslutte." ];

    int consoleWidth = Console.WindowWidth - 5;
    string consolePrefix = " \u2502";
    string consolePostfix = "\u2502 ";
    char consoleWall = '\u2500';
    Console.Clear();
    Console.WriteLine("C# Console Opgaver\n");
    Console.WriteLine($"\u250C{consoleWall}{new string(consoleWall, consoleWidth - consolePrefix.Length - consolePostfix.Length)}\u2510");

    foreach (string menuText in menuLines)
    {
        Console.WriteLine($"{consolePostfix}{menuText}{new string(' ', consoleWidth - consolePrefix.Length - consolePostfix.Length - menuText.Length)}{consolePostfix}");
    }
    Console.WriteLine($"\u2514{consoleWall}{new string(consoleWall, consoleWidth - consolePrefix.Length - consolePostfix.Length)}\u2518");
}