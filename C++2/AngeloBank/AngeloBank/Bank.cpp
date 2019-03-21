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
	Profile p;
	std::cout << "Username: ";
	std::string name;
	std::cin >> name;
	p.p_User = name;

	std::cout << "Address: ";
	std::string address;
	std::cin.ignore();	
	getline(std::cin, address);
	p.p_Address = address;

	profiles.push_back(p);

	std::cout << "Profile created";
	getchar();
}

void Bank::findAccount() {

	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;	

	for (int i = 0; i < profiles.size(); i++)
	{
		if (profiles[i].p_User == prof)
		{
			if (profiles[i].p_accounts.empty()) {
				profiles[i].createAccount();
			}
			else {
				for (int j = 0; j < profiles[i].p_accounts.size(); j++)
				{
					if (profiles[i].p_accounts.empty()) {
						profiles[i].createAccount();
						break;
					}
					else if (profiles[i].p_accounts[j].Balance < 25) {
						getchar();
						std::cout << "You have Balance in an account lower than 25 dolars" << std::endl;
						std::cout << "ID Account: ";
						std::cout << profiles[i].p_accounts[j].ID_Account;
						getchar();
						break;
					}
					else {
						profiles[i].createAccount();
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
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;

	for (int i = 0; i < profiles.size(); i++)
	{
		if (profiles[i].p_User == prof)
		{
			std::cout << "Which account: ";
			int account;
			std::cin >> account;

			for (int j = 0; j < profiles[i].p_accounts.size(); j++)
			{
				if (profiles[i].p_accounts[j].ID_Account == account)
				{
					getchar();
					std::cout << "Balance: " << profiles[i].p_accounts[j].Balance;
					getchar();
				}
				else {
					std::cout << "Wrong Account !";
					break;
				}
			}
			break;
		}
		else {
			std::cout << "Wrong Profile";
			getchar();
			break;
		}
	}
}

void Bank::withdrawMoneyFromAccount() {
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;

	for (int i = 0; i < profiles.size(); i++)
	{
		if (profiles[i].p_User == prof)
		{
			std::cout << "Which account: ";
			int account;
			std::cin >> account;

			for (int j = 0; j < profiles[i].p_accounts.size(); j++)
			{
				if (profiles[i].p_accounts[j].ID_Account == account)
				{
					std::cout << "How much you want to withdraw ?: ";
					int amount;
					std::cin >> amount;

					if (profiles[i].p_accounts[j].Balance >= amount) {

						profiles[i].p_accounts[j].Balance = profiles[i].p_accounts[j].Balance - amount;

						addValueToTransactionHistoryWithdraw(amount);

						getchar();
						std::cout << "Current Balance: " << profiles[i].p_accounts[j].Balance;
						getchar();
						break;
					}
					else {
						std::cout << "Not enough amount to withdraw !";
						getchar();
						break;
					}
				}
				else {
					std::cout << "Wrong Account !";
					getchar();
					break;
				}
				break;
			}
			break;
		}
		else {
			std::cout << "Wrong Profile";
			getchar();
			break;
		}
	}
}

void Bank::depositMoneyFromAccount() {
	std::cout << "Which profile: ";
	std::string prof;
	std::cin >> prof;

	for (int i = 0; i < profiles.size(); i++)
	{
		if (profiles[i].p_User == prof)
		{
			std::cout << "Which account: ";
			int account;
			std::cin >> account;

			for (int j = 0; j < profiles[i].p_accounts.size(); j++)
			{
				if (profiles[i].p_accounts[j].ID_Account == account)
				{
					std::cout << "How much you want to deposit ?: ";
					int amount;
					std::cin >> amount;

					addValueToTransactionHistoryDeposit(amount);

					profiles[i].p_accounts[j].Balance = profiles[i].p_accounts[j].Balance + amount;
					
					getchar();
					std::cout << "Current Balance: " << profiles[i].p_accounts[j].Balance;
					getchar();
					break;
				}
				else {
					std::cout << "Wrong Account !";
					getchar();
					break;
				}
				break;
			}
			break;
		}
		else {
			std::cout << "Wrong Profile";
			getchar();
			break;
		}
	}
}

void Bank::showTransactionHistory() {
	//show Deposits
	std::cout << "Deposits:" << std::endl;
	for (int i = 0; i < profiles.size(); i++)
	{
		for (int j = 0; j < profiles[i].p_accounts.size(); j++)
		{
			for (int l = 0; l < profiles[i].p_accounts[j].tHistoryDeposit.size(); l++)
			{
				std::cout << profiles[i].p_accounts[j].tHistoryDeposit[l] << std::endl;
			}
		}
	}

	//show Withdraw
	std::cout << "Withdraw:" << std::endl;
	for (int i = 0; i < profiles.size(); i++)
	{
		for (int j = 0; j < profiles[i].p_accounts.size(); j++)
		{
			for (int l = 0; l < profiles[i].p_accounts[j].tHistoryWithdraw.size(); l++)
			{
				std::cout << profiles[i].p_accounts[j].tHistoryWithdraw[l] << std::endl;
			}
			
		}
	}

	getchar();
	getchar();
}

void Bank::addValueToTransactionHistoryWithdraw(int amount) {
	
	for (int i = 0; i < profiles.size(); i++)
	{
		for (int j = 0; j < profiles[i].p_accounts.size(); j++)
		{
			profiles[i].p_accounts[j].tHistoryWithdraw.push_back(amount);
		}
	}
}

void Bank::addValueToTransactionHistoryDeposit(int amount) {

	for (int i = 0; i < profiles.size(); i++)
	{
		for (int j = 0; j < profiles[i].p_accounts.size(); j++)
		{
			profiles[i].p_accounts[j].tHistoryDeposit.push_back(amount);
		}
	}
}
