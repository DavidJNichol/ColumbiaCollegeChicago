#pragma once

#include <iostream>
#include <string>
#include <vector>
#include "Account.h"

class Profile
{
public:
	Profile();
	~Profile();
	void createAccount();

	int p_ID;
	std::string p_User;
	std::string p_Address;
	std::vector<Account*> p_accounts;
};

