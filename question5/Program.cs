
Console.WriteLine("Who are we trying to catch?");
string enemy = "";

TryToCatchVader(enemy);

static string TryToCatchVader(string darth)
{
    try
    {
        darth = int.TryParse(Console.ReadLine());
        return "Vader was Captured!";
    }
    catch(FormatException)
    {
        return "Vadar Got Away!";
    }
}