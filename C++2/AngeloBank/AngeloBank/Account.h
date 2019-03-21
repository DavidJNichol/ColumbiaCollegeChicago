#pragma once

#include <iostream>
#include <vector>

class Account
{
public:
	Account() :ID_Account(current_id++) { ID_Account = current_id; };
	~Account();

	void addValueToTransactionHistoryWithdraw(int amount);
	void addValueToTransactionHistoryDeposit(int amount);

	int ID_Account;
	int static current_id;
	int Balance;
	std::vector<int> tHistoryWithdraw;
	std::vector<int> tHistoryDeposit;
	
};

