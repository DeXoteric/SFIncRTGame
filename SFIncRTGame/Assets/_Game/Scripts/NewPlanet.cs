using UnityEngine;

public static class NewPlanet
{
    public static string GetPlanetName()
    {
        var planetName = RandomizePlanetName();
        return planetName;
    }

    private static string RandomizePlanetName()
    {
        var randomPlanetName = "";
        var rand = Random.Range(0, 2);
        if (rand == 0)
        {
            randomPlanetName = "Planet Name 1";
            //return randomPlanetName;
        }
        else if (rand == 1)
        {
            randomPlanetName = "Planet Name 2";
            //return randomPlanetName;
        }
        return randomPlanetName;
    }
}