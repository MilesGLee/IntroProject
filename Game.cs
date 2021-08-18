using System;
using System.Collections.Generic;
using System.Text;

namespace IntroProject
{
    class Game
    {
        //Character Variables
        int health;
        string name;
        string characterJob;
        int power;
        string path;
        //Stage Variables

        public void Run()
        {
            //Choose a name
            Console.WriteLine("Welcome! Please tell me your name:");
            Console.Write("> ");

            string nameInput = Console.ReadLine();

            name = nameInput;

            //Picking a job menu
            Console.WriteLine("Thank you! Now please pick a profession:");
            Console.WriteLine("1.Soldier");
            Console.WriteLine("2.Sorcerer");
            Console.Write("> ");

            string input = Console.ReadLine();

            if (input == "1" || input == "Soldier") //Picking Soldier Job
            {
                characterJob = "Soldier";
                health = 300;
                power = 400;
            }
            else if (input == "2" || input == "Sorcerer") //Picking Sorcerer Job
            {
                characterJob = "Sorcerer";
                health = 150;
                power = 15;
            }
            else //Error Message
            {
                Console.WriteLine("Invalid Input");
            }

            //display character statistics
            Console.WriteLine("Your Character Stats\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Job: " + characterJob);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Power: " + power);

            Console.ReadKey();
            Console.Clear();

            if (characterJob == "Soldier")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You arrive in a small village, your duty is to collect gifts from the peasants for your king. While the town looks poor and your sense of pride wavers, you stick to your loyalty to the king and ride into the village. After dismounting from your hourse you knock on the nearest buildings door. A small frizzled man opens it cautiosly and speaks aloud:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Hint: You are able to free response to certain NPC's, just make sure to use specific key words and keep it all lowercase. For this instance use words like 'take' 'gold' 'for' 'king'");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[Gilgamesh]: I-I am Gilgamesh, What brings thou here s-sir knight?");
                Console.ForegroundColor = ConsoleColor.White;
                string response;
                Console.Write($"<Sir {name}> ");
                response = Console.ReadLine();
                bool validResponse = false;
                while (validResponse == false) 
                {
                    if (response.Contains("take") && response.Contains("gold") && response.Contains("king") || response.Contains("taking"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[Gilgamesh]: M-My gold?! Wh-Whatever could the king need it for?! Is he not the king!");
                    }
                    else if (response.Contains("your") && response.Contains("gold") && response.Contains("for") && response.Contains("king"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[Gilgamesh]: M-My gold?! Wh-Whatever could you need it for sir knight!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[Gilgamesh]: I- Uhm... I'm n-not sure I quite understand sir knight.");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"<Sir {name}> ");
                    response = Console.ReadLine();
                }
            }
            
        }
    }
}
