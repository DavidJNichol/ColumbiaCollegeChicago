#pragma once
#include <vector>
#include "Profile.h"

class Bank
{
public:
	Bank();
	~Bank();

	std::vector<Profile> profiles;
};

