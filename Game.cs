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
                Console.WriteLine("You arrive in a small village, your duty is to collect gifts from the peasants for your king. While the town looks poor and your sense of pride wavers, you stick to your loyalty to the king and ride into the village. After dismounting from your hourse you knock on the nearest buildings door. A small frizzled man opens it cautiosly and speaks aloud:");
                Console.WriteLine("[Gilgamesh]: I-I am Gilgamesh, What brings thou here s-sir knight?");
                Console.Write($"<Sir {name}> ");
                Console.ReadLine();
            }
            
        }
    }
}
