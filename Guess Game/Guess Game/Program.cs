bool playAgain = true;
int answer = 0;
int guess = 0;

int min = 0;
int max = 100;
string response;
Random random = new Random();

while (playAgain)
{
    int guesses = 0;
    answer = random.Next(min, max + 1);
    while (guess != answer)
    {

        Console.WriteLine("Pick A Number Between " + min + " And " + max);
        guess = Convert.ToInt32(Console.ReadLine());
        if (guess > answer)
        {
            Console.WriteLine("That's pretty high!\tTry Again");
            Console.WriteLine("");
        }
        else if (guess < answer)
        {
            Console.WriteLine("That's Pretty Low!\tTry Again");
            Console.WriteLine("");
        }
        guesses++;

    }
    Console.WriteLine("Congrats You WON!");
    Console.WriteLine("The Number Was : " + answer);
    Console.WriteLine("The Number Of Guesses Was : " + guesses);

    Console.WriteLine("Wanna Continue ? (y/n)");
    response = Console.ReadLine();
    if (response == "n")
    {
        playAgain = false;
    }
    else if (response == "y")
    {
        playAgain = true;
    }
}