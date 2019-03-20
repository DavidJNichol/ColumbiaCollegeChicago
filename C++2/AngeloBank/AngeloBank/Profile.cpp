#include "stdafx.h"
#include "Profile.h"



Profile::Profile()
{
}


Profile::~Profile()
{
}

void Profile::createAccount() {
	
	Account a;
	
	a.Balance = 25;

	p_accounts.push_back(a);

	std::cout << "Your ID: " << a.ID_Account << std::endl;
	std::cout << "Your Balance: " << a.Balance << std::endl;

	std::cout << "Account created";
	a.ID_Account = a.ID_Account + 1;
	getchar();
}
