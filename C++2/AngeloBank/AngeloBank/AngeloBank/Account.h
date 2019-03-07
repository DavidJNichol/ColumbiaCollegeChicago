#pragma once

#include <vector>
#include "Profile.h"

class Account : Profile
{
public:
	Account();
	~Account();
	void createAccount();
	void checkBalanceAccount();

	int ID_Account;
	int Balance;
	
};

