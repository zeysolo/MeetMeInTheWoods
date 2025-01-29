using System;
using System.Collections.Generic;
using System.IO;

class FoxAdventureGame
{
    static string foxName = "";
    static bool helpedRabbits = false;
    static bool foundEagleFeather = false;
    static bool convincedEagle = false;
    static bool stoppedWolf = false;
    static bool helpedHedgehog = false;
    static bool protectedTreasure = false;
    static bool squirrelTrust = false;
    static bool owlWisdom = false;
    static string currentLocation = "The Whispering Glade"; // Starting location
    static List<string> inventory = new List<string>();
    static string saveFilePath = "FoxAdventureSave.txt";

    static void Main(string[] args)
    {
        Console.Title = "Vixen";
        MainMenu();
    }

    static void MainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("----v----");
            Console.WriteLine("\n1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                StartNewGame();
                break;
            }
            else if (choice == "2")
            {
                LoadGame();
                break;
            }
            else if (choice == "3")
            {
                Console.WriteLine("Farewell, wanderer...");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("A shadow veils your choice. Try again.");
                Console.ReadKey();
            }
        }
    }

    static void StartNewGame()
    {
        Console.Clear();
        Console.WriteLine("In the heart of the ancient forest, a fox stirs. It's name is...");
        foxName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(foxName))
        {
            foxName = "Nameless Fox";
        }
        Console.WriteLine($"{foxName}, awake.");
        Console.ReadKey();
        PlayGame();
    }

    static void PlayGame()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"You are looking to {currentLocation}, where shadows dance and secrets linger.");
            Console.WriteLine($"{foxName}. The forest watches, and the path ahead is shrouded in mystery.");
            Console.WriteLine("\nWhat will you do?");
            Console.WriteLine("1 - Aid the Timid Rabbits");
            Console.WriteLine("2 - Seek the Eagle's Favor");
            Console.WriteLine("3 - Confront the Shadow Wolf");
            Console.WriteLine("4 - Rescue the Trapped Hedgehog");
            Console.WriteLine("5 - Guard the Squirrel's Hoard");
            Console.WriteLine("6 - Seek Wisdom from the Owl");
            Console.WriteLine("7 - Inspect Your Belongings");
            Console.WriteLine("8 - Save Your Journey");
            Console.WriteLine("9 - Leave the Forest");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    HelpRabbits();
                    break;
                case "2":
                    ConvinceEagle();
                    break;
                case "3":
                    FaceTheWolf();
                    break;
                case "4":
                    HelpHedgehog();
                    break;
                case "5":
                    ProtectSquirrelTreasure();
                    break;
                case "6":
                    SeekOwlWisdom();
                    break;
                case "7":
                    CheckInventory();
                    break;
                case "8":
                    SaveGame();
                    break;
                case "9":
                    Console.WriteLine("The forest bids you farewell...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("The wind carries no answer. Choose again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void HelpRabbits()
    {
        Console.Clear();
        currentLocation = "The Rabbit's Glade";
        if (!helpedRabbits)
        {
            Console.WriteLine("You find yourself in a sunlit glade, where the rabbits tremble in fear.");
            Console.WriteLine("\"Oh, kind fox! The Shadow Wolf stalks us. Will you lend us your aid?\"");
            Console.WriteLine("\n1 - Aid the rabbits");
            Console.WriteLine("2 - Leave them to their fate");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                helpedRabbits = true;
                Console.WriteLine("You help the rabbits conceal their burrow, and they sigh in relief.");
                Console.WriteLine("Their eyes gleam with gratitude, and they pledge their support to you.");
                inventory.Add("Rabbit's Blessing");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You turn away, leaving the rabbits to their despair. Their whispers haunt you.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The forest grows silent, as if mocking your indecision.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The rabbits nod in recognition. You have already earned their trust.");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void ConvinceEagle()
    {
        Console.Clear();
        currentLocation = "The Eagle's Perch";
        if (!convincedEagle)
        {
            Console.WriteLine("You climb to the Eagle's Perch, where the great bird watches with piercing eyes.");
            Console.WriteLine("\"What brings you here, little fox?\" it asks, its voice like the wind.");
            Console.WriteLine("To earn its trust, you must find one of its feathers, lost in the forest depths.");
            Console.WriteLine("\n1 - Search for the feather");
            Console.WriteLine("2 - Leave without its favor");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (!foundEagleFeather)
                {
                    if (inventory.Contains("Forest Key"))
                    {
                        foundEagleFeather = true;
                        Console.WriteLine("With the Forest Key, you delve into the ancient woods and find the eagle's feather.");
                        Console.WriteLine("You present it to the eagle, and its gaze softens.");
                        convincedEagle = true;
                        inventory.Add("Eagle's Alliance");
                        Console.WriteLine("\"You have proven yourself, fox. My wings are yours to call upon.\"");
                    }
                    else
                    {
                        Console.WriteLine("The forest guards its secrets well. You must explore further.");
                    }
                }
                else
                {
                    Console.WriteLine("You already hold the eagle's feather.");
                }
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You descend the perch, the eagle's eyes following you with silent judgment.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The wind howls, as if scolding your hesitation.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The eagle nods, its trust unwavering. The skies are yours to command.");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void FaceTheWolf()
    {
        Console.Clear();
        currentLocation = "The Wolf's Lair";
        if (!stoppedWolf)
        {
            Console.WriteLine("You venture into the Wolf's Lair, where shadows writhe and the air is thick with menace.");
            Console.WriteLine("The Shadow Wolf emerges, its eyes glowing like embers in the dark.");
            Console.WriteLine("\n1 - Stand your ground");
            Console.WriteLine("2 - Retreat into the shadows");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (helpedRabbits && convincedEagle && protectedTreasure && helpedHedgehog)
                {
                    Console.WriteLine("With the strength of your allies, you drive the wolf back into the abyss. The forest sighs in relief.");
                    stoppedWolf = true;
                }
                else
                {
                    Console.WriteLine("You are not yet ready to face the wolf. Seek the aid of the forest's creatures.");
                }
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You slip away, the wolf's laughter echoing behind you.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The forest holds its breath, waiting for your decision.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The wolf is gone, and the forest is at peace. Your courage is remembered.");
            Console.ReadKey();
        }
    }

    static void HelpHedgehog()
    {
        Console.Clear();
        currentLocation = "The Hedgehog's Hollow";
        if (!helpedHedgehog)
        {
            Console.WriteLine("You find a hedgehog trapped in a pit, its spines quivering with fear.");
            Console.WriteLine("\"Please, help me!\" it pleads, its voice trembling like the leaves.");
            Console.WriteLine("\n1 - Rescue the hedgehog");
            Console.WriteLine("2 - Leave it to its fate");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                helpedHedgehog = true;
                Console.WriteLine("You free the hedgehog, and it gifts you a \"Protective Thorn\" as thanks.");
                inventory.Add("Protective Thorn");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You walk away, the hedgehog's cries fading into the forest's gloom.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The forest seems to hold its breath, awaiting your choice.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The hedgehog nods, its gratitude evident. You are remembered fondly.");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void ProtectSquirrelTreasure()
    {
        Console.Clear();
        currentLocation = "The Squirrel's Cache";
        if (!protectedTreasure)
        {
            Console.WriteLine("A squirrel scurries to you, its eyes wide with fear.");
            Console.WriteLine("\"Please, guard my hoard! Thieves lurk in the shadows!\"");
            Console.WriteLine("\n1 - Protect the hoard");
            Console.WriteLine("2 - Ignore the plea");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                protectedTreasure = true;
                squirrelTrust = true;
                Console.WriteLine("You stand watch, and the hoard remains safe. The squirrel gifts you a \"Forest Key.\"");
                inventory.Add("Forest Key");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You turn away, and the squirrel's eyes fill with sorrow.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The forest whispers, urging you to choose wisely.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The squirrel's hoard is safe, and it chirps its thanks.");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void SeekOwlWisdom()
    {
        Console.Clear();
        currentLocation = "The Owl's Tree";
        if (!owlWisdom)
        {
            Console.WriteLine("The wise owl perches above, its eyes gleaming with ancient knowledge.");
            Console.WriteLine("\"Answer my riddle, fox, and I shall share my wisdom.\"");
            Console.WriteLine("The owl's riddle: \"What creature walks on four legs at dawn, two at noon, and three at dusk?\"");
            Console.WriteLine("\n1 - Human");
            Console.WriteLine("2 - Fox");
            Console.WriteLine("3 - Eagle");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                owlWisdom = true;
                Console.WriteLine("The owl nods. \"Correct! Take this gift of wisdom.\"");
                inventory.Add("Owl's Wisdom");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The owl shakes its head. \"Farewell, until you learn the truth.\"");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The owl's wisdom is already yours. The forest bows to your knowledge.");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void CheckInventory()
    {
        Console.Clear();
        Console.WriteLine("Your Belongings:");
        if (inventory.Count > 0)
        {
            foreach (var item in inventory) Console.WriteLine("- " + item);
        }
        else Console.WriteLine("Your paws are empty.");
        Console.ReadKey();
    }

    static void SaveGame()
    {
        using (StreamWriter sw = new StreamWriter(saveFilePath))
        {
            sw.WriteLine(foxName);
            sw.WriteLine(helpedRabbits);
            sw.WriteLine(foundEagleFeather);
            sw.WriteLine(convincedEagle);
            sw.WriteLine(stoppedWolf);
            sw.WriteLine(helpedHedgehog);
            sw.WriteLine(protectedTreasure);
            sw.WriteLine(squirrelTrust);
            sw.WriteLine(owlWisdom);
            sw.WriteLine(currentLocation);
            sw.WriteLine(string.Join(",", inventory));
        }
        Console.WriteLine("Your journey has been saved.");
        Console.ReadKey();
    }

    static void LoadGame()
    {
        if (File.Exists(saveFilePath))
        {
            using (StreamReader sr = new StreamReader(saveFilePath))
            {
                foxName = sr.ReadLine();
                helpedRabbits = bool.Parse(sr.ReadLine());
                foundEagleFeather = bool.Parse(sr.ReadLine());
                convincedEagle = bool.Parse(sr.ReadLine());
                stoppedWolf = bool.Parse(sr.ReadLine());
                helpedHedgehog = bool.Parse(sr.ReadLine());
                protectedTreasure = bool.Parse(sr.ReadLine());
                squirrelTrust = bool.Parse(sr.ReadLine());
                owlWisdom = bool.Parse(sr.ReadLine());
                currentLocation = sr.ReadLine();
                inventory = new List<string>(sr.ReadLine().Split(','));
            }
            Console.WriteLine("Your journey has been restored.");
            Console.ReadKey();
            PlayGame();
        }
        else
        {
            Console.WriteLine("No saved journey found.");
            Console.ReadKey();
            MainMenu();
        }
    }
}