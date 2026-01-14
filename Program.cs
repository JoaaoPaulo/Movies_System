class Program{

    public void ShowMenu()
    {
        int option = 0;

        Console.Clear();

        Console.WriteLine("Choose an option: ");
        Console.WriteLine("1 - Register a Movie");
        Console.WriteLine("2 - See the information about a movie");
        Console.WriteLine("3 - See the list of registered movies");

        option = int.Parse(Console.ReadLine());
        
        switch (option)
        {
            case 1:
                Catalog.RegisterMovie();
                break;
            case 2:
                Catalog.ShowMovieInformation();
                break;
            case 3:
                Movie.ShowMoviesList();
                break;
        }


        Console.WriteLine("\n\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}
