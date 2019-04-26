#pragma once
#include <vector>
#include <iostream>
#include "Food.h"
#include "Order.h"

class Restaurant
{
public:
	Restaurant();
	~Restaurant();

	int askFoodCustomer();
	void showMenuOfFood();
	void addFoodToOrder(int option);
	void showCustomerOrder();

private:
	std::vector<Food*> list_of_food;
	std::vector<Order*> customer_order;
};

