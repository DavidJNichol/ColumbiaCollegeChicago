#pragma once
#include <string>
#include <vector>
#include "Bank.h"

class Profile : Bank
{
public:
	Profile();
	~Profile();
	void createProfile();

	int ID;
	std::string User;
	std::string Address;
	std::vector<int> Accounts;

};

