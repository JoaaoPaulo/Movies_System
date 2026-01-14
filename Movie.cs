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
        Console.Writeline("----Movie Information----");
        Console.Writeline($"Title: {Title}");
        Console.Writeline($"Duration: {Duration}");
        Console.Writeline($"Synopsis: {Synopsis}");
    }
    
}