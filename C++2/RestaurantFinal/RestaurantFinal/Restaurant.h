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
	bool askCustomerMoreFood();
	double chargeCustomer();
	void returnChangeToCustomer(double customer_money);
	void openTheRestaurant();

private:
	std::vector<Food*> list_of_food;
	std::vector<Order*> customer_order;
};

