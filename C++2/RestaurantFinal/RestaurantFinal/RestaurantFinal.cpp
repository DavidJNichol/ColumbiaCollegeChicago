// RestaurantFinal.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Restaurant.h"

int main()
{
	Restaurant *r = new Restaurant();
	
	r->showMenuOfFood();
	int x = r->askFoodCustomer();
	r->addFoodToOrder(x);
	r->showCustomerOrder();

    return 0;
}

