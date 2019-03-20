#pragma once
#include "Account.h"
#include <vector>
#include <string>

class TransactionHistory
{
public:
	TransactionHistory();
	~TransactionHistory();

	std::vector<std::string> Deposits;
	std::vector<std::string> Whitdraw;
};

