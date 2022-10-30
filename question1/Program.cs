
string[] starWarsCharacter = new string[] { "Luke", "Darth Vader", "Yoda", "Obi-wan", "R2-D2" };


AddStarsWarsCharacters(starWarsCharacter);

static string AddStarsWarsCharacters(string[] searchYoda)
{
    int error = -1;
    var index = Array.FindIndex(searchYoda, x => x.Contains("Yoda"));

    if (index >= 0)
    {
        return index.ToString();
    }
    else
    {
        return error.ToString();
    }

}

