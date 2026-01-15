class Movie{
    
    public string Title { get; }
    public string Duration { get; }
    public string Synopsis { get; set; }

    public Movie(string title , string duration, string synopsis)
    {
        Title = title;
        Duration = duration;
        Synopsis = synopsis;
    }

    public void ShowDetails()
    {
        Console.WriteLine("----Movie Information----");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Synopsis: {Synopsis}");
    }
    
}