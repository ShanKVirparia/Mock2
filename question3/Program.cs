
string[] planets = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

ConvertPlanets(planets);

static List<string> ConvertPlanets(string[] planets)
{
    List<string> reversedPlants = planets.Reverse().ToList();
    
    return reversedPlants;
}