#include "stdafx.h"
#include "Account.h"


Account::Account() 
{
}

Account::~Account()
{
}

void Account::addValueToTransactionHistoryWithdraw(int amount) {
	Transaction *t = new Transaction();
	
	t->Withdraw= amount;

	t_History.push_back(&(*t));
}

void Account::addValueToTransactionHistoryDeposit(int amount) {

	Transaction *t = new Transaction();

	t->Deposits = amount;

	t_History.push_back(&(*t));
}

