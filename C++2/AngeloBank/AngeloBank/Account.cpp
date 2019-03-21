#include "stdafx.h"
#include "Account.h"

Account::~Account()
{
}

void Account::addValueToTransactionHistoryWithdraw(int amount) {


	tHistoryWithdraw.push_back(amount);
}

void Account::addValueToTransactionHistoryDeposit(int amount) {


	tHistoryWithdraw.push_back(amount);
}

