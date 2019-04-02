#pragma once

#include <iostream>
#include <string>
#include <vector>
#include "Transaction.h"

class Account
{
public:
	Account();
	~Account();

	void addValueToTransactionHistoryWithdraw(int amount);
	void addValueToTransactionHistoryDeposit(int amount);

	
	int Balance;
	int ID_Account;
	std::vector<Transaction*> t_History;

};

