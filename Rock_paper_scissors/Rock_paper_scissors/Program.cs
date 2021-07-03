using System;

namespace Rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, cpuInput;
            int randomInt;
            bool playAgain = true;
            string igrat;

            while (playAgain)
            {
                int userScore = 0;
                int cpuScore = 0;

                while (userScore < 3 && cpuScore < 3)
                {
                    Console.WriteLine("Vnesi: kamen, papir, skarje:   ");
                    userInput = Console.ReadLine();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            cpuInput = "kamen";
                            Console.WriteLine("\nRacunalnik izbere kamen");
                            if (userInput == "kamen")
                            {
                                Console.WriteLine("draw");
                            }
                            else if (userInput == "papir")
                            {
                                Console.WriteLine("ti zmagas");
                                userScore++;
                            }
                            else if (userInput == "skarje")
                            {
                                Console.WriteLine("racunalnik zmaga");
                                cpuScore++;
                            }
                            break;
                        case 2:
                            cpuInput = "papir";
                            Console.WriteLine("\nRacunalnik izbere papir");
                            if (userInput == "kamen")
                            {
                                Console.WriteLine("racunalnik zmaga");
                                cpuScore++;
                            }
                            else if (userInput == "papir")
                            {
                                Console.WriteLine("draw");
                            }
                            else if (userInput == "skarje")
                            {
                                Console.WriteLine("ti zmagas");
                                userScore++;
                            }
                            break;
                        case 3:
                            cpuInput = "skarje";
                            Console.WriteLine("\nRacunalnik izbere skarje");
                            if (userInput == "kamen")
                            {
                                Console.WriteLine("ti zmagas");
                                userScore++;
                            }
                            else if (userInput == "papir")
                            {
                                Console.WriteLine("racunalnik zmaga");
                                cpuScore++;
                            }
                            else if (userInput == "skarje")
                            {
                                Console.WriteLine("draw");
                            }
                            break;
                        default:
                            Console.WriteLine("Napacen vnos!");
                            break;
                    }

                    Console.WriteLine("\nTocke racunalnika: " + cpuScore);
                    Console.WriteLine("Tocke igralca: " + userScore + "\n\n\n");

                    if (cpuScore == 3)
                    {
                        Console.WriteLine("Racunalnik je zmagal");
                    }
                    else if (userScore == 3)
                    {
                        Console.WriteLine("Ti si zmagal");
                    }
                    else
                    {

                    }
                }

                Console.WriteLine("Zelis igrati se naprej? vpisi y ali n");
                igrat = Console.ReadLine();
                if (igrat == "y")
                {
                    playAgain = true;
                }
                else if (igrat == "n")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Nepravilen vnos. Vnesi y, kot DA ali n, kot NE. ");
                }

            }
        }
    }
}
