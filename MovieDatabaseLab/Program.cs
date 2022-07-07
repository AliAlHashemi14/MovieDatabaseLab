using MovieDatabaseLab;

//necessary variables
bool runProgram = true;
    List<Movie> movies = new List<Movie>()
{
    new Movie("Parasite", "Horror"),
    new Movie("The Wailing","Horror"),
    new Movie("The Matrix","Scifi"),
    new Movie("Interstellar","Scifi"),
    new Movie("West Side Story", "Drama"),
    new Movie("The Shawshank Redemption", "Drama"),
    new Movie("Dragon Ball Z: Super Android 13","Animated"),
    new Movie("A Silent Voice", "Animated"),
    new Movie("Rurouni Kenshin: Trust and Betrayal","Animated"),
    new Movie("Akira","Animated")
};

//Main loop
while (runProgram)
{
    Console.WriteLine("Welcome to the movie list application!");
    Console.WriteLine($"There are {movies.Count} movies in this list.");
    //storing the return string
    string choice = Validator.GetUserResponse();
    MovieSearch(choice);

    //get continue loop
    runProgram = Validator.GetContinue();
}

//method to search list for category
void MovieSearch(string choice)
{
    foreach (Movie movie in movies)
    {
        if(movie.Category.ToLower().Trim() == choice)
        {
            Console.WriteLine(movie.Title);
        }
    }
       
}