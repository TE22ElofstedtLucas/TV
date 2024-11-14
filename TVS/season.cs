using System;
using System.Collections.Generic;

public class Season
{
    public int SeasonNumber { get; set; }
    public List<Episode> Episodes { get; set; }

    public Season(int seasonNumber)
    {
        SeasonNumber = seasonNumber;
        Episodes = new List<Episode>();
    }

    // Add episodes to the season
    public void AddEpisodes(int numOfEpisodes)
    {
        for (int i = 1; i <= numOfEpisodes; i++)
        {
            Episodes.Add(new Episode($"Episode {Episodes.Count + 1}", 0));
        }
    }

    // Print information about the season
    public void PrintInfo()
    {
        Console.WriteLine($"Season {SeasonNumber}: {Episodes.Count} episodes");
        foreach (var episode in Episodes)
        {
            episode.PrintInfo();
        }
    }
}
