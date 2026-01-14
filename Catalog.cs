class Catalog{


    public List<Movie> movies = new List<Movie>();

    public void RegisterMovie(){
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Duration: ");
        string duration = Console.ReadLine();
        Console.Write("Synopsis: ");
        string synopsis = Console.ReadLine();

        Movie movie = new Movie(title, duration, synopsis);
        movies.Add(movie);

        Console.WriteLine("Movie registered successfully");
    }

    public void ListMovies()
    {
        for(int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {movies[i].Title}"); 
        }
    }

    public void ShowMovieInformation()
    {
        Console.Write("Movie title:");
        title = Console.ReadLine();

        foreach (Movie movie in movies)
        {
            if (movie.Title.Equals(title, StringComparision.OrdinalIgnoreCase))
            {
                movie.Sh
            }
        }
    }
}