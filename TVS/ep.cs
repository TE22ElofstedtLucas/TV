using System;

public class Episode
{
    public string Title { get; set; }
    public int Rating { get; set; }

    public Episode(string title, int rating)
    {
        Title = title;
        Rating = rating;
    }

    // Print information about the episode
    public void PrintInfo()
    {
        Console.WriteLine($"  - {Title} (Rating: {Rating})");
    }
}
