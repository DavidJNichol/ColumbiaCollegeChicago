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
			profiles[i].createAccount();
			getchar();
			break;
		}
		else {
			std::cout << "Fuck you";
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
					std::cout << "Balance: " << profiles[i].p_accounts[j].Balance;
					getchar();
					break;
				}
				else {
					std::cout << "Fuck you again !";
				}
				break;
			}
			break;
		}
		else {
			std::cout << "Fuck you";
			getchar();
			break;
		}
	}
}
