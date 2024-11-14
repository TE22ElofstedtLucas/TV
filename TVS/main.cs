using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class TvMain
{
    private List<TvSeries> shows;
    private const string FILE_PATH = "tv_series.json";

    public TvMain()
    {
        shows = new List<TvSeries>();
    }

    // Write data to a JSON file
    public void WriteToFile()
    {
        try
        {
            string jsonData = JsonConvert.SerializeObject(shows, Formatting.Indented);
            File.WriteAllText(FILE_PATH, jsonData);
            Console.WriteLine("Data saved to file.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving data: {e.Message}");
        }
    }

    // Read data from a JSON file
    public void ReadFromFile()
    {
        try
        {
            if (File.Exists(FILE_PATH))
            {
                string jsonData = File.ReadAllText(FILE_PATH);
                shows = JsonConvert.DeserializeObject<List<TvSeries>>(jsonData) ?? new List<TvSeries>();
                Console.WriteLine("Data loaded from file.");
            }
            else
            {
                Console.WriteLine("File not found, starting with an empty list.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error reading data: {e.Message}");
        }
    }

    // Create initial dataset
    public void CreateData()
    {
        TvSeries series1 = new TvSeries("Breaking Bad");
        series1.AddEpisodes(7, 1);
        series1.ChangeRating(9);
        shows.Add(series1);

        TvSeries series2 = new TvSeries("Game of Thrones");
        series2.AddEpisodes(10, 1);
        series2.ChangeRating(8);
        shows.Add(series2);

        WriteToFile(); // Save initial data to file
    }
}
