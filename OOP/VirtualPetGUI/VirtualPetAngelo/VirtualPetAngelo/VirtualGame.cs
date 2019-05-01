using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetAngelo
{
    public class VirtualGame
    {
        Player player;

        List<Item> items;
        List<Pet> pets;
        
        

        public VirtualGame()
        {
            player = new Player();
            
            setupGame();
        }

        public void setupGame()
        {
            initializePet();
            initializeItem();
            initializePlayerItems();
        }

        public void initializePlayerItems()
        {
            player.PlayerItems = new List<Item>() { };
        }

        public void initializePet()
        {
            pets = new List<Pet>()
            {
                new Monkey(){PetName = "Josh", PetPrice = 300 },
                new Turtle(){PetName = "Carlos", PetPrice = 500 },
                new Dinossaur(){PetName = "Viviane", PetPrice = 1000 }
            };

        }

        public void initializeItem()
        {
            items = new List<Item>()
            {
                new Ball{ ItemName = "LightBall", ItemPrice = 100, ItemSkill = 10  },
                new Boomerang{ ItemName = "Dark Boomerang", ItemPrice = 175, ItemSkill = 20  },
                new Rope{ ItemName = "Rope", ItemPrice = 200, ItemSkill = 5  }
            };
        }

        //public void Start()
        //{
        //    Console.WriteLine(showFirstBanner());
        //    createPlayer();
        //    choosePet();
        //    GameMainMenu();
            
        //}

        public string showFirstBanner()
        {
            string s = "*********** Welcome to the Brazilian Virtual Pet ***********";
            return s;
        }

        public string askPlayerName()
        {
            string s = "What is your name ?";
            return s;
        }

        public void createPlayer(string playerName)
        {
            player.PlayerName = playerName;

            player.PlayerWallet = 400;
            player.PlayerScore = 0;
        }

        public string showPlayerName()
        {
            string s = $"{player.PlayerName}";
            return s;
        }

        public string showPlayerWallet()
        {
            string s = $"${player.PlayerWallet}";
            return s;
        }

        public string showPlayerPet()
        {
            string s = $"{player.MyPet.ToString()}";
            return s;
        }

        public List<Pet> getListOfPets()
        {
            return this.pets;
        }

        public void choosePet(string petSelected)
        {
            bool choosed = true;

            while (choosed)
            {
                string choose = petSelected;
                int index = 0;
                int.TryParse(choose, out index);

                if (pets[index].PetPrice > player.PlayerWallet)
                {
                    showNotEnoughMoneyMessage();
                    choosed = true;
                }
                else
                {
                    try
                    {
                        player.MyPet = pets[index];
                        choosed = false;
                        player.PlayerWallet = player.PlayerWallet - pets[index].PetPrice;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }               

            }
        }

        private string showNotEnoughMoneyMessage()
        {
            string s = "You don't have enough money to buy this pet";
            return s;
        }

        public void buyItem()
        {
            Console.Clear();
            Console.WriteLine($"{player.PlayerName} has ${player.PlayerWallet} in his wallet");
            Console.WriteLine("Which item do you want to buy ?");
            bool choosed = true;

            foreach (Item item in items)
            {
                Console.WriteLine($"{items.IndexOf(item) + 1}.{item.ItemName.ToString().Replace("VirtualPetAngelo.", "")}\t Price: {item.ItemPrice}\t Skill: {item.ItemSkill}");
            }
            Console.WriteLine("Exit(0)");

            while (choosed)
            {

                string option = Console.ReadLine();
                if(option == "0")
                {
                    break;
                }
                int index = 0;
                int.TryParse(option, out index);

                if(items[index - 1].ItemPrice > player.PlayerWallet)
                {
                    
                    Console.WriteLine("You don't have enough money to buy this item");
                    Console.WriteLine("Choose another Item");
                    break;

                }
                else
                {
                    try
                    {
                        player.PlayerItems.Add(items[index - 1]);
                        choosed = false;
                        player.PlayerWallet = player.PlayerWallet - items[index - 1].ItemPrice;

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    returnGameMenu();
                }
            }
        }

        public void returnGameMenu()
        {            
            Console.Clear();
            GameMainMenu();
        }

        public void showProfile()
        {
            Console.Clear();
            Console.WriteLine($"{player.PlayerName} Profile");
            Console.WriteLine($"My pet is a {player.MyPet.ToString().Replace("VirtualPetAngelo.", "")}");
            Console.WriteLine($"Wallet: {player.PlayerWallet}");
            Console.WriteLine($"Score: {player.PlayerScore}");            
            Console.WriteLine("My Items:");
            foreach(Item item in player.PlayerItems)
            {
                Console.WriteLine(item.ItemName.ToString().Replace("VirtualPetAngelo.", "\t"));
            }

            returnGameMenu();
        }

        public void showPetStatus()
        {
            Console.Clear();
            Console.WriteLine($"{player.MyPet.ToString().Replace("VirtualPetAngelo.", "")} Status");
            Console.WriteLine($"Skill: {player.MyPet.PetSkill}");

            
            returnGameMenu();
        }

        public void playWithPet()
        {
            
            Console.Clear();
            Console.WriteLine("Which item do you want to play with ?");

            foreach (Item item in player.PlayerItems)
            {
                Console.WriteLine($"{player.PlayerItems.IndexOf(item) + 1}. {item.ItemName}");
            }

            string option = Console.ReadLine();
            int index = 0;
            int.TryParse(option, out index);

            Console.WriteLine($"{player.MyPet.ToString().Replace("VirtualPetAngelo.", "")} is playing with the {items[index - 1].ItemName.ToString().Replace("VirtualPetAngelo.", "")}");

            player.MyPet.PetSkill += 10;
            player.PlayerScore += 10;

            returnGameMenu();
            
        }

        public void evolvePet()
        {
            Console.WriteLine("**** Evolving you pet ****");
            Console.WriteLine("For this important reason you going to need: ");
            Console.WriteLine("Score: 100");
            Console.WriteLine("Wallet: 5000");
            Console.WriteLine("Skill: 2000");
            Console.WriteLine("");
            Console.WriteLine($"{player.PlayerName} Information:");
            Console.WriteLine($"Score: {player.PlayerScore}");
            Console.WriteLine($"Wallet: {player.PlayerWallet}");
            Console.WriteLine($"Skill: {player.MyPet.PetSkill}");
            Console.WriteLine("");

            if (player.PlayerScore == 100 && player.PlayerWallet == 5000 && player.MyPet.PetSkill == 2000)
            {
                Console.WriteLine("Do you want to Continue");
                Console.WriteLine("Yes(1)/ No(2)");

                string option = Console.ReadLine();
                int answer = 0;
                int.TryParse(option, out answer);

                if(answer == 1)
                {

                    if(player.MyPet.ToString().Replace("VirtualPetAngelo.", "") == "Monkey")
                    {
                        player.MyPet = new FireMonkey();
                        Console.WriteLine(player.MyPet.ToString().Replace("VirtualPetAngelo.", ""));
                        returnGameMenu();
                    }
                    else if (player.MyPet.ToString().Replace("VirtualPetAngelo.", "") == "Turtle")
                    {
                        player.MyPet = new MetalTurtle();
                        Console.WriteLine(player.MyPet.ToString().Replace("VirtualPetAngelo.", ""));
                        returnGameMenu();
                    }
                    else if(player.MyPet.ToString().Replace("VirtualPetAngelo.", "") == "Dinossaur")
                    {
                        player.MyPet = new Dragon();
                        Console.WriteLine(player.MyPet.ToString().Replace("VirtualPetAngelo.", ""));
                        returnGameMenu();
                    }

                }else if(answer == 2)
                {
                    Console.WriteLine("See you next time !");
                    returnGameMenu();
                }

            }
            else
            {
                Console.WriteLine("You don't have enough resources for this action yet !");
                returnGameMenu();
            }

        }

        private void sellItem()
        {
            Console.Clear();
            Console.WriteLine("Which item do you want to sell from your items ?");

            foreach (Item item in player.PlayerItems)
            {
                Console.WriteLine($"{player.PlayerItems.IndexOf(item) + 1}. {item.ItemName} ${item.ItemPrice}");
            }

            string option = Console.ReadLine();
            int index = 0;
            int.TryParse(option, out index);

            Console.WriteLine($"{player.PlayerItems[index -1].ItemName} sold");

            player.PlayerWallet += player.PlayerItems[index - 1].ItemPrice;
            player.PlayerItems.RemoveAt(index - 1);
            returnGameMenu();

        }

        public void makeMoney()
        {
            Console.WriteLine("What a smart player...");
            Console.WriteLine("So do you want to make more money ?");
            Console.WriteLine("Then tell me which number I'm thinking right now between 1 and 10:");

            string option = Console.ReadLine();
            int number = 0;
            int.TryParse(option, out number);
            
            if(number == generateRandomNumber())
            {
                Console.WriteLine("Congratulations!!!");
                Console.WriteLine("You got $10.");

                player.PlayerWallet += 10;
                returnGameMenu();
            }
            else
            {
                Console.WriteLine("Sorry, try next time !");
                returnGameMenu();
            }
        }

        public int generateRandomNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            return number;
        }

        public void GameMainMenu()
        {
            Console.Clear();

            Console.WriteLine("Your journey starts know...");
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("- Player(p)");
            Console.WriteLine("- Pet(t)");
            Console.WriteLine("- Store(s)");
            Console.WriteLine("0. Exit");
            bool isPlaying = true;

            while (isPlaying)
            {
                string option = Console.ReadLine();
                switch(option)
                {
                    case "p":
                        GamePlayerMenu();
                        break;
                    case "t":
                        GamePetMenu();
                        break;
                    case "s":
                        GameStoreMenu();
                        break;
                    default:
                        isPlaying = false;
                        break;
                }
            }
        }

        public void GamePetMenu()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("- Play with your Pet(t)");
            Console.WriteLine("- Evolve your Pet(e)");
            Console.WriteLine("- Pet Status(s)");
            Console.WriteLine("- Return(r)");
            bool isPlaying = true;

            while (isPlaying)
            {
                string option = Console.ReadLine();
                switch (option)
                {
                    case "t":
                        if (player.PlayerItems.Count <= 0)
                        {
                            Console.WriteLine("You dont have any items in your list.");
                        }
                        else
                        {
                            playWithPet();
                        }
                        break;
                    case "e":
                        evolvePet();
                        break;
                    case "s":
                        showPetStatus();
                        break;
                    case "r":
                        GameMainMenu();
                        break;
                    default:
                        isPlaying = false;
                        break;
                }
            }
        }

        public void GamePlayerMenu()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("- Your Profile(p)");
            Console.WriteLine("- Make money(m)");
            Console.WriteLine("- Return(r)");
            bool isPlaying = true;

            while (isPlaying)
            {
                string option = Console.ReadLine();
                switch (option)
                {
                    case "p":
                        showProfile();
                        break;
                    case "m":
                        makeMoney();
                        break;
                    case "r":
                        GameMainMenu();
                        break;
                    default:
                        isPlaying = false;
                        break;
                }
            }
        }

        public void GameStoreMenu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Wallmart Pet");
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("- Buy items(b)");
            Console.WriteLine("- Sell items(s)");
            Console.WriteLine("- Return(r)");
            bool isPlaying = true;

            while (isPlaying)
            {
                string option = Console.ReadLine();
                switch (option)
                {
                    case "b":
                        buyItem();
                        break;
                    case "s":
                        sellItem();
                        break;
                    case "r":
                        GameMainMenu();
                        break;
                    default:
                        isPlaying = false;
                        break;
                }
            }
        }


    }
}