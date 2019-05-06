using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeFinal
{
    public abstract class Icecream
    {
        public double Price;
        public List<Scoop> Scoops;
        public List<Topping> Toppings;

        public Icecream()
        {
            this.Price += .5;
            this.Scoops = new List<Scoop>();
            this.Toppings = new List<Topping>();
        }

        public string About()
        {
            string s = string.Empty;
            s = "IceCream Order\n";
            s += "Item \tPrice\n";
            s += $"{this.ToString().Replace("PracticeFinal.", "")}\t{this.Price:c}\n";
            s += showListOfScoops();
            s += showListOfToppings();
            s += "--------------------\n";
            s += $"Total:  {this.GetPrice():c}\n";

            return s;
        }

        public void AddScoop(Scoop s)
        {
            this.Scoops.Add(s);
        }

        public string showListOfScoops()
        {
            string s = string.Empty;
            foreach(var item in Scoops)
            {
                s += $"{item.flavor} \t{item.Price:c}\n";
            }
            return s;
        }

        public void AddTopping(Topping t)
        {
            this.Toppings.Add(t);
        }

        public string showListOfToppings()
        {
            string s = string.Empty;
            foreach (var item in Toppings)
            {
                s += $"{item.Name} \t{item.Price:c}\n";
            }
            return s;
        }

        public double GetPrice()
        {
            return this.Price + toppingPrice() + scoopPrice();
        }

        public double toppingPrice()
        {
            double totalToppingPrice = 0;
            foreach (var item in this.Scoops)
            {
                totalToppingPrice += item.Price;
            }

            return totalToppingPrice;
        }

        public double scoopPrice()
        {
            double totalScoopPrice = 0;
            foreach (var item in this.Toppings)
            {
                totalScoopPrice += item.Price;
            }

            return totalScoopPrice;
        }
    }
}