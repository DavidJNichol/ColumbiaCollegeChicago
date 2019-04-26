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

	Order *test = new Order();
	test->o_bill = 0;
	for (int i = 0; i < customer_order.size(); i++)
	{
		test->o_foods.push_back("teste");
	}

	customer_order.push_back(&(*test));
	
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

bool Restaurant::askCustomerMoreFood() {
	
	int option;
	bool ask = false;
	bool correctanswer = true;

	while (correctanswer) {

		std::cout << "Do you want more ?" << std::endl;
		std::cout << "1(Yes) / 2(No) ?" << std::endl;
		std::cin >> option;

		if (option == 1) {
			ask = true;
			correctanswer = false;
		}
		else if (option == 2) {
			correctanswer = false;
		}
		else {
			std::cout << "Type again !" << std::endl;
			correctanswer = true;
		}
	}
	
	return ask;
}

void Restaurant::addFoodToOrder(int option) {

	std::string choose_food;
	double price_food;

	for (int i = 0; i < list_of_food.size(); i++)
	{
		if (i == option - 1) {
			choose_food = list_of_food[i]->name;
			price_food = list_of_food[i]->price;
		}
	}

	for (int j = 0; j < customer_order.size(); j++)
	{
		customer_order[j]->o_foods.push_back(choose_food);
		customer_order[j]->o_bill += price_food;
	}
}

void Restaurant::showCustomerOrder() {
	std::cout << std::endl;

	for (int i = 0; i <= customer_order.size(); i++)
	{
		std::cout << "Order Items: " << std::endl;

		for (int j = 0; j < customer_order[i]->o_foods.size(); j++)
		{
			std::cout << customer_order[i]->o_foods[j] << std::endl;
		}
		
		std::cout << std::endl;
		std::cout << "Bill: ";
		std::cout << customer_order[i]->o_bill;
		break;
	}	
	std::cout << std::endl;
}

double Restaurant::chargeCustomer() {

	double customer_money;

	std::cout << "Customer Money: ";
	std::cin >> customer_money;
	std::cout << std::endl;

	return customer_money;
}

void Restaurant::returnChangeToCustomer(double customer_money) {
	
	double bill;

	for (int i = 0; i < customer_order.size(); i++)
	{
		bill = customer_order[i]->o_bill;
	}

	double change = (customer_money - bill);
	std::cout << "Total change= $" << change << " \n";

	int dollars = change / 1.00;
	change = change - dollars;

	int quarters = change / 0.25;
	change = change - (quarters * 0.25);

	int dimes = change / 0.10;
	change = change - (dimes * 0.10);

	int nickels = change / 0.05;
	change = change - (nickels * 0.05);

	int pennies = change / 0.01;
	change = change - (pennies * 0.01);

	std::cout << "Number of dollars: " << dollars << " \n";
	std::cout << "Number of quarters: " << quarters << " \n";
	std::cout << "Number of dimes: " << dimes << " \n";
	std::cout << "Number of nickels: " << nickels << " \n";
	std::cout << "Number of pennies: " << pennies << " \n";
}

void Restaurant::openTheRestaurant() {
	bool question = true;

	while (question) {
		showMenuOfFood();
		int x = askFoodCustomer();
		addFoodToOrder(x);
		question = askCustomerMoreFood();
		system("CLS");
	}

	showCustomerOrder();
	double customer_money = chargeCustomer();
	returnChangeToCustomer(customer_money);
}