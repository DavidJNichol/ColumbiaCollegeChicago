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
	void withdrawMoneyFromAccount();
	void depositMoneyFromAccount();
	void showTransactionHistory();
	void addValueToTransactionHistoryWithdraw(int amount);
	void addValueToTransactionHistoryDeposit(int amount);


	std::vector<Profile> profiles;
};