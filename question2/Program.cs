
Dictionary<string, int> starWarsCharacter = new Dictionary<string, int>()
{
    {"Darth Vader", 140},
    {"Obi-Wan", 150},
    {"Luke", 125},
    {"Yoda", 160}
};

DeathStarCombat(starWarsCharacter);

static void DeathStarCombat(Dictionary<string, int> strongestFighter)
{
    Console.WriteLine($"The strongest fighter is {strongestFighter.Keys.Max()}, {strongestFighter.Values.Max()}");
}