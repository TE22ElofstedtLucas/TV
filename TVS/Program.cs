using System;
using System.Collections.Generic;

public class TvSeries
{
    public string Name { get; set; }
    public Dictionary<int, Season> Seasons { get; set; }
    public int Rating { get; set; }

    // Default constructor
    public TvSeries()
    {
        Console.Write("Enter TV Series name: ");
        Name = Console.ReadLine();
        Seasons = new Dictionary<int, Season>();
        Rating = 0; // Default rating
    }

    // Parameterized constructor
    public TvSeries(string inName)
    {
        Name = inName;
        Seasons = new Dictionary<int, Season>();
        Rating = 0; // Default rating
    }

    // Add episodes to a specific season
    public void AddEpisodes(int numOfEpisodes, int seasonNumber)
    {
        if (!Seasons.ContainsKey(seasonNumber))
        {
            Seasons[seasonNumber] = new Season(seasonNumber);
        }
        Seasons[seasonNumber].AddEpisodes(numOfEpisodes);
    }

    // Change the rating of the TV series
    public void ChangeRating(int newRating)
    {
        Rating = newRating;
    }

    // Print information about the TV series
    public void PrintInfo()
    {
        Console.WriteLine($"TV Series Name: {Name}");
        Console.WriteLine($"Rating: {Rating}");
        Console.WriteLine("Seasons:");
        foreach (var season in Seasons.Values)
        {
            season.PrintInfo();
        }
    }
}
