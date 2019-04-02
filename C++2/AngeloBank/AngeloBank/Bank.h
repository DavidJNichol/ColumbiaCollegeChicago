#include "Profile.h"
#include "Account.h"
#include "Transaction.h"
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
	void showTransactionHistoryDeposit();
	void showTransactionHistoryWithdraw();
	void addValueToTransactionHistoryWithdraw(int amount, int account);
	void addValueToTransactionHistoryDeposit(int amount, int account);


	std::vector<Profile*> profiles;
};