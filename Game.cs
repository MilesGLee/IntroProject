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
            Console.Title = "Wow! Another fantasy text based adventure game!";
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
            displayStats();

            Console.ReadKey();
            Console.Clear();

            if (characterJob == "Soldier") 
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You arrive in a small village, your duty is to collect gifts from the peasants for your king. While the town looks poor and your sense of pride wavers, you stick to your loyalty to the king and ride into the village. After dismounting from your hourse you knock on the nearest buildings door. A small frizzled man opens it cautiosly and speaks aloud:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[Gilgamesh]: I-I am Gilgamesh, What brings thou here s-sir knight?");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("1. I am here for thou's gold, courtesy of the king of course! 2. What bring's me here is none of your consern, peasent. Now bring me your gold!");
                Console.ForegroundColor = ConsoleColor.White;
                string response1;
                Console.Write($"<Sir {name}> ");
                response1 = Console.ReadLine();
                bool validResponse1 = false;
                while (validResponse1 == false) 
                {
                    if (response1 == "I am here for thou's gold, courtesy of the king of course!" || response1 == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[Gilgamesh]: M-My gold?! Wh-Whatever could the king need it for?! Is he not the king!");
                        validResponse1 = true;
                        path = "king";
                    }
                    else if (response1 == "2" || response1 == "What bring's me here is none of your consern, peasent. Now bring me your gold!")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[Gilgamesh]: G-Gah! M-My gold?! Is this a robbery?!");
                        validResponse1 = true;
                        path = "robbery";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[Gilgamesh]: I- Uhm... I'm n-not sure I quite understand sir knight.");
                    }
                    if (validResponse1 == false)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"<Sir {name}> ");
                        response1 = Console.ReadLine();
                    }
                }
                Console.ReadKey();
                if (path == "king") 
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"<Sir {name}> The king requires it, my deepest condolences... Now, the gold.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("[Gilgamesh]: Alright fine, fine. You win.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("The frail man leaves the door open and scurry's back into his house, seemingly to get the gold.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("1. Follow him 2. Wait at the door");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"<Sir {name}> ");
                    string response2 = Console.ReadLine();
                    bool validResponse2 = false;
                    while (validResponse2 == false) 
                    {
                        if (response2 == "Follow him" || response2 == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("You follow where you saw the frail man walk away.");
                            validResponse2 = true;
                            path = "follow";
                        }
                        else if (response2 == "2" || response2 == "Wait at the door")
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("You wait at the door for something to happen.");
                            validResponse2 = true;
                            path = "wait";
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Nothing happens...");
                        }
                        if (validResponse2 == false)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"<Sir {name}> ");
                            response2 = Console.ReadLine();
                        }
                    }
                    Console.ReadKey();
                    if (path == "follow") 
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"As you enter the house you hear some shuffling in a room to your left.");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("1. Enter room 2. Call to Gilgamesh");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"<Sir {name}> ");
                        string response3 = Console.ReadLine();
                        bool validResponse3 = false;
                        while (validResponse3 == false)
                        {
                            if (response3 == "Enter room" || response3 == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("You slowly enter the room and see Gilgamesh entranced and performing some sort of magical summoning ritual! This is a highly illegal action and you are within your rights to arrest him.");
                                validResponse3 = true;
                                path = "arrest";
                            }
                            else if (response3 == "2" || response3 == "Call to Gilgamesh")
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("You shout out calling to Gilgamesh, but to no avail.");
                                validResponse3 = false;
                                path = "wait";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Nothing happens...");
                            }
                            if (validResponse3 == false)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"<Sir {name}> ");
                                response3 = Console.ReadLine();
                            }
                        }
                        Console.ReadKey();
                        if (path == "arrest") 
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("You briskly draw your sword and swiftly *bonk* Gilgamesh over the head with it. He falls to the ground unconsious. You write up a report on your scroll and send it to the king via horse mail. In 10-20 buisiness days you hear back and Gilgamesh is locked up for his crimes.");
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The End. You got the 'Performing the arcana? Not on my watch! *Bonk* go to magic jail' ending! Congradulations.");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                    if (path == "wait") 
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You continue to wait at the door...");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("1. Continue to wait 2. Give up and go home");
                        Console.ForegroundColor = ConsoleColor.White;
                        string response3;
                        Console.Write($"<Sir {name}> ");
                        response3 = Console.ReadLine();
                        bool validResponse3 = false;
                        int waitTime = 0;
                        while (validResponse3 == false)
                        {
                            
                            if (response3 == "Continue to wait" || response3 == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine($"You continue to wait at the door.... ");
                                validResponse3 = false;
                                path = "waiting";
                                waitTime++;
                            }
                            else if (response3 == "2" || response3 == "Give up and go home")
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("You give up and go home, you hope you don't get fired for this.");
                                validResponse3 = true;
                                path = "give up";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Nothing happens...");
                            }
                            if (waitTime == 3)
                            {
                                validResponse3 = true;
                                path = "dragon";
                            }
                            if (validResponse3 == false)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"<Sir {name}> ");
                                response3 = Console.ReadLine();
                            }
                        }
                        if (path == "give up")
                        {
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The End. You got the 'I don't have time for this and I'm bored' ending! Congradulations.");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        if (path == "dragon") 
                        {
                            //Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Much to your suprise, an elder dragon appears from the sky attacking the village. You raise your shield and sword preparing for combat, but the dragon does not notice you as its landing on the village. Unfortunatly you were right square underneath where the dragon was trying to land and got squished.");
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The End. You got the 'Wow, this guy is taking a while to get the gol- Oh my lord is that a f**king dragon!?' ending! Congradulations.");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                }
                if (path == "robbery") 
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"<Sir {name}> You know what? I'm tired of this. Yes. This IS a robbery! Hand over thine shillings!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"You draw your sword and brandish it at Gilgamesh");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("[Gilgamesh]: Oh! W-what a foul and corrupt kingdom this has become!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Gilgamesh repeatedly and annoyingly cries out while handing over all his gold.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"You take his coin and leave town on your horse. Not exactly proud of your actions, but contempt with them. The king will be happy with this at least.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The End. You got the 'In the name of my own patients by god I will rob you' ending! Congradulations.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }

            } //Soldier Route
            if (characterJob == "Sorcerer") 
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"You are {name} a local peasent in a poorish town. You're unhappy with the way the king is leading the nation but you live with it. You are also the strongest sorcerer in all the land. But practicing magic is one of the highest punishable crimes possible, so out of the goodness in your heart you restrain yourself. On one particular evening you hear a knocking on your door and you open it to a knight on your doorstep.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"<{name}>: I am {name}, What brings thou here sir knight?");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[Sir Knight]: I am here to (wrongfully) collect thine gold for the king! A kings got to line his pockets somehow right?");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("1. Uh, sure let me go get my gold 2. What kind of insecure king needs his peasants gold!");
                Console.ForegroundColor = ConsoleColor.White;
                string response1;
                Console.Write($"<{name}> ");
                response1 = Console.ReadLine();
                bool validResponse1 = false;
                while (validResponse1 == false)
                {
                    if (response1 == "Uh, sure let me go get my gold" || response1 == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("[Sir Knight]: Very well, I shall await here for your return!");
                        validResponse1 = true;
                        path = "get gold";
                    }
                    else if (response1 == "What kind of insecure king needs his peasants gold!" || response1 == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("[Sir Knight]: What is all this insolence!? I will not have my king ridiculed by the common peasentry! Have at thee!");
                        validResponse1 = true;
                        path = "fight";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("[Sir Knight]: I am awaiting your response...");
                    }
                    if (validResponse1 == false)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"<{name}> ");
                        response1 = Console.ReadLine();
                    }
                }
                Console.ReadKey();
                if (path == "fight") 
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Try as he might, the soldier draws his sword and tries to enter you into combat. But how unfortunate that he does not know how formiddable of a foe he is facing, as you do so much as flick your wrist and the soldier evaporates before you. But what is even more unfortunate is a peasent passing by happened to see, so you run away leaving your boring peasent life behind.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The End. You got the 'Uh oh, I vaporized a soldier and now I'm fighting an entire nation' ending! Congradulations.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                if (path == "get gold") 
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You head back into your house to your spell casting room. And begin performing a great summoning spell to spawn a dragon that you will sick on the knight, because you just dont want to give him or anyone your gold. The spell finishes and you leave the village as it is being ravaged by an elder dragon.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The End. You got the 'I'm so petty I literally summoned an elder dragon rather than pay taxes' ending! Congradulations.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.ReadKey();
            } //Sorcerer Route

        }

        void displayStats() 
        {
            Console.WriteLine("Your Character Stats\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Job: " + characterJob);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Power: " + power);
        }
    }
}
