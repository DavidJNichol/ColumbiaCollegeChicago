// AngeloBank.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Bank.h"
#include "Profile.h"
#include "Account.h"
#include <iostream>

int main()
{
	int choice = 0;

	Bank *b = new Bank();
	do
	{
		choice = 0;
		std::cout << std::endl
			<< " 1 - Create Profile.\n"
			<< " 2 - Create Account.\n"
			<< " 3 - Show Account Status.\n"
			<< " 4 - Withdraw.\n"
			<< " 5 - Deposit.\n"
			<< " 6 - Show Transaction History(Withdraw).\n"
			<< " 7 - Show Transaction History(Deposit).\n"
			<< " 8 - Exit.\n"
			<< " Enter your choice and press return: ";
		std::cin >> choice;

		switch (choice)
		{
		case 1:
			b->createProfile();
			system("CLS");
			break;
		case 2:
			b->findAccount();
			system("CLS");
			break;
		case 3:
			b->showAccountStatus();
			system("CLS");
			break;
		case 4:
			b->withdrawMoneyFromAccount();
			system("CLS");
			break;
		case 5:
			b->depositMoneyFromAccount();
			system("CLS");
			break;
		case 6:
			b->showTransactionHistoryWithdraw();
			system("CLS");
			break;
		case 7:
			b->showTransactionHistoryDeposit();
			system("CLS");
			break;
		case 8:
			std::cout << "End of the program. \n";
			break;
		default:
			std::cout << "Not a Valid Choice. \n"
				<< "Choose again.\n";
			break;
		}

	} while (choice != 8);

    return 0;
}

