using LinqIntro;

Console.WriteLine("Siffror:");
var numbers = new List<int>
{ 
    0, 1, 2, 3, 3, 5, 14, 21, 34
};

// Vi ska skapa en list med alla siffror högre än 5!

// Utan Linq
var numbersOverFive = new List<int>();
foreach (var num in numbers)
{
    if (num > 5)
    {
        numbersOverFive.Add(num);
        Console.WriteLine(num + " Siffran är över 5 NO LINQ");
    }
}
Console.WriteLine("-----------------------------------------------------");
// Med Linq
var numbersOverFiveLinq = numbers.Where(n => n > 5).ToList();

numbersOverFive.ForEach(n => Console.WriteLine(n + " Siffran är över 5 LINQ"));

// Man kan tänka så här...
// Linq loopar igenom varje iteration och skapa en metod som liknar denna

// static bool NumIsOverFive(int n)
// {
//     return n > 5;
// }

Console.WriteLine("======================================================");
//STEAM STEAM STEAM STEAM ///////////////////////////////////////////////////////////////////////
var gameList = new List<Game>
{
    new Game{Name="Death Stranding", ReleaseDate = new DateTime(2019,11,8), SteamScore = 9},
    new Game{Name="Dark Souls 3", ReleaseDate = new DateTime(2015,3,24), SteamScore = 9},
    new Game{Name="Cyberpunk 2077", ReleaseDate = new DateTime(2020,9,17), SteamScore = 7},
    new Game{Name="Valheim", ReleaseDate = new DateTime(2021,2,2), SteamScore = 10}
};


// Vi skriver in ett SteamScore och då vill vi få alla spel tillbaka
// som har det värdet eller högre.
// Vi vill även sortera på spelets namn!

Console.WriteLine("Skriv in ett SteamScore 1-10 för att ta fram spel med samma eller högre score");
int scoreInput = Convert.ToInt32(Console.ReadLine());

// Exempel 1
foreach (var g in gameList.Where(g => g.SteamScore >= scoreInput).OrderByDescending(g => g.Name))
{
    Console.WriteLine($"{g.Name} Score: {g.SteamScore} ");
}

// Exempel 2
var scoreMatch = gameList
    .Where(g => g.SteamScore >= scoreInput)
    .OrderByDescending(g => g.Name)
    .ToList();

//Skriv ut med foreach ELLER .ForEach
foreach (var game in scoreMatch)
{
    Console.WriteLine($"{game.Name} Score: {game.SteamScore} ");

}

//scoreMatch.ForEach(g => Console.WriteLine($"{g.Name} Score: {g.SteamScore}"));

// Här kollar vi om ALLA spel har ett SteamScore på 9 eller högre (returnerar False!)
bool allHave9ScoreOrBetter = gameList.All(game => game.SteamScore >= 9);

// ///////////////////////////////////////////////////////////////////////




Console.ReadLine();