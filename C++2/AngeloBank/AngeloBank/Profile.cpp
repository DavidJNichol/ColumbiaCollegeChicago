#include "stdafx.h"
#include "Profile.h"



Profile::Profile()
{
}


Profile::~Profile()
{
}

void Profile::createAccount() {
	
	Account *a = new Account();;

	int account = 0;
	bool exists = true;

	for (int i = 0; i < p_accounts.size(); i++)
	{
		std::cout << "My Accounts ID: " << p_accounts[i]->ID_Account << std::endl;
	}


	std::cout << "Choose a number for your account: ";
	std::cin >> account;
	a->ID_Account = account;
	a->Balance = 25;

	std::cout << "Your ID: " << a->ID_Account << std::endl;
	std::cout << "Your Balance: " << a->Balance << std::endl;

	p_accounts.push_back(&(*a));
	std::cout << "Account created";
	
	getchar();
}