#include "stdafx.h"
#include "Restaurant.h"
#include <vector>


Restaurant::Restaurant()
{
	Food *coffee = new Food();
	Food *latte = new Food();
	Food *egg = new Food();
	Food *doughnut = new Food();

	coffee->name = "Coffee";
	coffee->price = 1.00;

	latte->name = "Latte";
	latte->price = 2.55;

	egg->name = "Egg Sandwich";
	egg->price = 3.75;

	doughnut->name = "Doughnut";
	doughnut->price = 3.22;

	list_of_food.push_back(&(*coffee));
	list_of_food.push_back(&(*latte));
	list_of_food.push_back(&(*egg));
	list_of_food.push_back(&(*doughnut));
}


Restaurant::~Restaurant()
{
}

void Restaurant::showMenuOfFood() {

	std::cout << "BRAZILIAN FOOD TRUCK !" << std::endl;
	for (int i = 0; i < list_of_food.size(); i++) {
		
		std::cout << i + 1 << ".Item: " << list_of_food[i]->name << std::endl;
		std::cout << "Price: $"  << list_of_food[i]->price << std::endl;
		std::cout << std::endl;
	}
}

int Restaurant::askFoodCustomer() {

	int option;

	std::cout << "Which items do you want to add to your order ?" << std::endl;
	std::cin >> option;

	return option;
}

void Restaurant::addFoodToOrder(int option) {

	for (int i = 0; i < list_of_food.size(); i++)
	{
		for (int j = 0; j < customer_order.size(); j++)
		{
			for (int l = 0; l < customer_order[j]->o_foods.size(); l++)
			{
				if (i == option - 1) {
					customer_order[j]->o_foods[l] = list_of_food[i]->name;
					customer_order[j]->o_bill += list_of_food[i]->price;
				}
			}
		}			
	}
}

void Restaurant::showCustomerOrder() {

	for (int i = 0; i < customer_order.size(); i++)
	{
		std::cout << "Order Items: " << std::endl;

		for (int j = 0; j < customer_order[i]->o_foods.size(); j++)
		{
			std::cout << customer_order[i]->o_foods[j] << std::endl;
		}
		
		std::cout << "Bill: ";
		std::cout << customer_order[i]->o_bill;
		getchar();
	}	
}
