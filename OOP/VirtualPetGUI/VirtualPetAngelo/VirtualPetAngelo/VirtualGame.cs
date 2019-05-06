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

        public string showPlayerPetSkill()
        {
            string s = $"{player.MyPet.PetSkill.ToString()}";
            return s;
        }

        public string showPlayerScore()
        {
            string s = player.PlayerScore.ToString();
            return s;
        }

        public List<Pet> getListOfPets()
        {
            return this.pets;
        }

        public List<Item> getListOfPlayerItems()
        {
            return player.PlayerItems;
        }
        
        public bool choosePet(string petSelected)
        {
            bool goodPurchased = false;
            int index = 0;

            foreach (var pet in pets)
            {

                if (pet.GetType().ToString().Replace("VirtualPetAngelo.", "") == petSelected)
                {
                    goodPurchased = true;
                    index = pets.IndexOf(pet);
                    break;
                }
            }

            if (pets[index].PetPrice > player.PlayerWallet)
            {
                goodPurchased = false;
            }
            else
            {
                try
                {
                    player.MyPet = pets[index];
                    player.PlayerWallet = player.PlayerWallet - pets[index].PetPrice;
                    goodPurchased = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return goodPurchased;
        }

        private string showNotEnoughMoneyMessage()
        {
            string s = "You don't have enough money to buy this pet";
            return s;
        }

        public List<Item> getListItems()
        {
            return items;
        }

        public bool buyItem(string chooseItem)
        {
            bool goodPurchased = false;
            int index = 0;

            foreach (var item in items)
            {
                
                if (item.ItemName == chooseItem)
                {
                    goodPurchased = true;
                    index = items.IndexOf(item);
                    break;
                }
            }

            if(items[index].ItemPrice > player.PlayerWallet)
            {
                goodPurchased = false;
            }
            else
            {
                try
                {
                    player.PlayerItems.Add(items[index]);
                    player.PlayerWallet = player.PlayerWallet - items[index].ItemPrice;
                    goodPurchased = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return goodPurchased;
        }

        public void playWithPet()
        {
            player.MyPet.PetSkill += 10;
            player.PlayerScore += 10;           
        }

        public string playPetMenu()
        {
            string s = "Which item do you want to play with ?";
            return s;
        }

        public string evolvePetNeedsMessage()
        {
            string s = "For this important reason you going to need: ";
            s += "Score: 100";
            s += "Wallet: 5000";
            s += "Skill: 2000";

            return s;
        }

        public bool evolvePet()
        {
            bool evolved = false;
            if (player.PlayerScore == 100 && player.PlayerWallet == 5000 && player.MyPet.PetSkill == 2000)
            {
                if(player.MyPet.ToString().Replace("VirtualPetAngelo.", "") == "Monkey")
                {
                    player.MyPet = new FireMonkey();
                    evolved = true;
                }
                else if (player.MyPet.ToString().Replace("VirtualPetAngelo.", "") == "Turtle")
                {
                    player.MyPet = new MetalTurtle();
                    evolved = true;
                }
                else if(player.MyPet.ToString().Replace("VirtualPetAngelo.", "") == "Dinossaur")
                {
                    player.MyPet = new Dragon();
                    evolved = true;
                }
            }

            return evolved;
        }

        public bool sellItem(string chooseItem)
        {
            int index = 0;
            bool didIt = false;

            foreach (Item item in player.PlayerItems)
            {
                if (item.ItemName == chooseItem)
                {
                    didIt = true;
                    index = items.IndexOf(item);
                    break;
                }
            }

            player.PlayerWallet += player.PlayerItems[index].ItemPrice;
            player.PlayerItems.RemoveAt(index);

            return didIt;
        }

        public string sellItemMessage()
        {
            string s = "Sold Item";
            return s;
        }

        public bool makeMoney(string moneyOption)
        {
            string option = moneyOption;
            int number = 0;
            int.TryParse(option, out number);
            bool answerStatus = false;

            if (number == generateRandomNumber())
            {
                answerStatus = true;
                
                player.PlayerWallet += 10;
            }
            return answerStatus;
        }

        public string makeMoneyRightAnswer()
        {
            string s = "Congratulations!!!";
            s += "You got $10.";
            return s;
        }

        public string makeMoneyWrongAnswer()
        {
            string s = "Sorry, try next time !";
            return s;
        }

        public string makeMoneyMenu()
        {
            string s = $"What a smart player...\r";
            s += $"So do you want to make more money ?\r";
            s += $"Then tell me which number I'm thinking right now between 1 and 10:";

            return s;
        }

        public int generateRandomNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            return number;
        }
    }
}