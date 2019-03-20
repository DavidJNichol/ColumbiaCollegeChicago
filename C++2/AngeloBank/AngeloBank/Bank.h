#include "Profile.h"
#include "Account.h"
#include <iostream>
#include <algorithm>
#include <sstream>
#include <string>
#include <vector>

class Bank
{
	
public:
	Bank();
	~Bank();
	void createProfile();
	void findAccount();
	void showAccountStatus();

	std::vector<Profile> profiles;
};