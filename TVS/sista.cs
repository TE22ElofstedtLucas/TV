using System;

public class Program
{
    public static void Main(string[] args)
    {
        TvMain tvMain = new TvMain();
        tvMain.CreateData();  // Only call this method once, can be removed after initial run
        tvMain.ReadFromFile();
    }
}
