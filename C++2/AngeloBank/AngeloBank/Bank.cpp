#include "stdafx.h"
#include "Bank.h"

Bank::Bank()
{
	
}


Bank::~Bank()
{
}

void Bank::createProfile()
{
	Profile *p = new Profile();
	std::cout << "Username: ";
	std::string name;
	std::cin >> name;
	p->p_User = name;

	std::cout << "Address: ";
	std::string address;
	std::cin.ignore();	
	getline(std::cin, address);
	p->p_Address = address;

	profiles.push_back(&(*p));

	std::cout << "Profile created";
	getchar();
}

void Bank::findAccount() {
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;	

	for (int i = 0; i < profiles.size(); i++)
	{
		if (profiles[i]->p_User == prof)
		{
			if (profiles[i]->p_accounts.empty()) {
				profiles[i]->createAccount();
			}
			else {
				for (int j = 0; j < profiles[i]->p_accounts.size(); j++)
				{
					if (profiles[i]->p_accounts.empty()) {
						profiles[i]->createAccount();
						break;
					}
					else if (profiles[i]->p_accounts[j]->Balance < 25) {
						getchar();
						std::cout << "You have Balance in an account lower than 25 dolars" << std::endl;
						std::cout << "ID Account: ";
						std::cout << profiles[i]->p_accounts[j]->ID_Account;
						getchar();
						break;
					}
					else {
						profiles[i]->createAccount();
						break;
					}
				}
			}
			getchar();
			break;
		}
	}
}

void Bank::showAccountStatus() {
	for (int i = 0; i < profiles.size(); i++)
	{
		std::cout << profiles[i]->p_User << std::endl;
	}
	
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;

	for (int i = 0; i < profiles.size(); i++)
	{
		for (int k = 0; k < profiles[i]->p_accounts.size(); k++)
		{
			std::cout << profiles[i]->p_accounts[k]->ID_Account << std::endl;
		}


		if (profiles[i]->p_User == prof)
		{
			std::cout << "Which account: ";
			int account;
			std::cin >> account;

			for (int j = 0; j < profiles[i]->p_accounts.size(); j++)
			{
				if (profiles[i]->p_accounts[j]->ID_Account == account)
				{
					getchar();
					std::cout << "Balance: " << profiles[i]->p_accounts[j]->Balance;
					getchar();
				}
			}
		}
	}
}

void Bank::withdrawMoneyFromAccount() {
	for (int i = 0; i < profiles.size(); i++)
	{
		std::cout << profiles[i]->p_User << std::endl;
	}
	
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;

	for (int i = 0; i < profiles.size(); i++)
	{
		if (profiles[i]->p_User == prof)
		{
			for (int k = 0; k < profiles[i]->p_accounts.size(); k++)
			{
				std::cout << profiles[i]->p_accounts[k]->ID_Account << std::endl;
			}


			std::cout << "Which account: ";
			int account;
			std::cin >> account;

			for (int j = 0; j < profiles[i]->p_accounts.size(); j++)
			{
				if (profiles[i]->p_accounts[j]->ID_Account == account) {
					std::cout << "How much you want to withdraw ?: ";
					int amount;
					std::cin >> amount;

					if (profiles[i]->p_accounts[j]->Balance > amount) {
						profiles[i]->p_accounts[j]->Balance = profiles[i]->p_accounts[j]->Balance - amount;

						addValueToTransactionHistoryWithdraw(i, amount, j);

						getchar();
						std::cout << "Current Balance: " << profiles[i]->p_accounts[j]->Balance;
						getchar();
						break;
					}
					else {
						getchar();
						std::cout << "Not Enough money to withdraw ! " << std::endl;
						std::cout << std::endl;
						std::cout << "Current Balance: " << profiles[i]->p_accounts[j]->Balance << std::endl;
						std::cout << "Amount requested: " << amount;
						getchar();
						break;
					}
				}
			}
		}
	}
}

void Bank::depositMoneyFromAccount() {
	for (int i = 0; i < profiles.size(); i++)
	{
		std::cout << profiles[i]->p_User << std::endl;
	}
	
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;

	for (int i = 0; i < profiles.size(); i++)
	{
		if (profiles[i]->p_User == prof)
		{
			for (int k = 0; k < profiles[i]->p_accounts.size(); k++)
			{
				std::cout << profiles[i]->p_accounts[k]->ID_Account << std::endl;
			}


			std::cout << "Which account: ";
			int account;
			std::cin >> account;

			for (int j = 0; j < profiles[i]->p_accounts.size(); j++)
			{
				if (profiles[i]->p_accounts[j]->ID_Account == account) {
					std::cout << "How much you want to deposit ?: ";
					int amount;
					std::cin >> amount;

					profiles[i]->p_accounts[j]->Balance = profiles[i]->p_accounts[j]->Balance + amount;

					addValueToTransactionHistoryDeposit(i, amount, j);

					getchar();
					std::cout << "Current Balance: " << profiles[i]->p_accounts[j]->Balance;
					getchar();
					break;
				}
			}
		}
	}
}

void Bank::showTransactionHistoryDeposit() {
	for (int i = 0; i < profiles.size(); i++)
	{
		std::cout << profiles[i]->p_User << std::endl;
	}
	
	//show Deposits
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;

	for (int i = 0; i < profiles.size(); i++)
	{
		for (int k = 0; k < profiles[i]->p_accounts.size(); k++)
		{
			std::cout << profiles[i]->p_accounts[k]->ID_Account << std::endl;
		}

		if (profiles[i]->p_User == prof)
		{
			std::cout << "Which account: ";
			int account;
			std::cin >> account;

			for (int j = 0; j < profiles[i]->p_accounts.size(); j++)
			{
				if (profiles[i]->p_accounts[j]->ID_Account == account) {

					std::cout << "Deposit:" << std::endl;

					for (int l = 0; l < profiles[i]->p_accounts[j]->t_History.size(); l++)
					{

						std::cout << profiles[i]->p_accounts[j]->t_History[l]->Deposits << std::endl;
					}
				}
			}
		}
	}

	getchar();
	getchar();
}

void Bank::showTransactionHistoryWithdraw() {
	for (int i = 0; i < profiles.size(); i++)
	{
		std::cout << profiles[i]->p_User << std::endl;
	}
	
	//show Withdraw
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;

	for (int i = 0; i < profiles.size(); i++)
	{
		for (int k = 0; k < profiles[i]->p_accounts.size(); k++)
		{
			std::cout << profiles[i]->p_accounts[k]->ID_Account << std::endl;
		}

		if (profiles[i]->p_User == prof)
		{
			std::cout << "Which account: ";
			int account;
			std::cin >> account;

			for (int j = 0; j < profiles[i]->p_accounts.size(); j++)
			{
				if (profiles[i]->p_accounts[j]->ID_Account == account) {

					std::cout << "Withdraw:" << std::endl;
					
					for (int l = 0; l < profiles[i]->p_accounts[j]->t_History.size(); l++)
					{

						std::cout << profiles[i]->p_accounts[j]->t_History[l]->Withdraw << std::endl;
					}
				}				
			}
		}
	}
	getchar();
	getchar();
}

void Bank::addValueToTransactionHistoryWithdraw(int profile, int amount, int account) {
	
	for (int i = 0; i < profiles.size(); i++)
	{
		for (int j = 0; j < profiles[i]->p_accounts.size(); j++)
		{
			if (i == profile && j == account) {
				profiles[profile]->p_accounts[account]->addValueToTransactionHistoryWithdraw(amount);
			}			
		}
	}
}

void Bank::addValueToTransactionHistoryDeposit(int profile, int amount, int account) {

	for (int i = 0; i < profiles.size(); i++)
	{
		for (int j = 0; j < profiles[i]->p_accounts.size(); j++)
		{
			if (i == profile && j == account) {
				profiles[profile]->p_accounts[account]->addValueToTransactionHistoryDeposit(amount);
			}
		}
	}
}

void Bank::transferMoneyBetweenAccounts() {
	for (int i = 0; i < profiles.size(); i++)
	{
		std::cout << profiles[i]->p_User << std::endl;
	}
	
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;

	for (int i = 0; i < profiles.size(); i++)
	{
		if (profiles[i]->p_User == prof)
		{
			for (int k = 0; k < profiles[i]->p_accounts.size(); k++)
			{
				std::cout << profiles[i]->p_accounts[k]->ID_Account << std::endl;
			}


			std::cout << "Which account to Withdraw: ";
			int account1;
			std::cin >> account1;

			std::cout << "Which account to Deposit: ";
			int account2;
			std::cin >> account2;

			std::cout << "How much money to transfer ?: ";
			int amount;
			std::cin >> amount;

			for (int j = 0; j < profiles[i]->p_accounts.size(); j++)
			{
				//Will withdraw
				if (profiles[i]->p_accounts[j]->ID_Account == account1) {
					
					if (profiles[i]->p_accounts[j]->Balance > amount) {
						profiles[i]->p_accounts[j]->Balance = profiles[i]->p_accounts[j]->Balance - amount;

						addValueToTransactionHistoryWithdraw(i, amount, j);

						getchar();
						std::cout << "Account: " << profiles[i]->p_accounts[j]->ID_Account << std::endl;
						std::cout << "Current Balance: " << profiles[i]->p_accounts[j]->Balance;
						getchar();
					}
					else {
						getchar();
						std::cout << "Not Enough money to transfer " << std::endl;
						std::cout << std::endl;
						std::cout << "Account: " << profiles[i]->p_accounts[j]->ID_Account << std::endl;
						std::cout << "Current Balance: " << profiles[i]->p_accounts[j]->Balance << std::endl;
						std::cout << "Amount requested: " << amount;
						getchar();
						break;
					}
					
				}
				//Will deposit
				else if (profiles[i]->p_accounts[j]->ID_Account == account2) {
					
					profiles[i]->p_accounts[j]->Balance = profiles[i]->p_accounts[j]->Balance + amount;

					addValueToTransactionHistoryDeposit(i, amount, j);

					getchar();
					std::cout << "Account: " << profiles[i]->p_accounts[j]->ID_Account << std::endl;
					std::cout << "Current Balance: " << profiles[i]->p_accounts[j]->Balance;
					getchar();
					break;
				}
			}
		}
	}
}
