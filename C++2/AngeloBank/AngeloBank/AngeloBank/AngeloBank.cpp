// AngeloBank.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Profile.h"
#include "Account.h"
#include <iostream>

int main()
{
	int choice;
	Profile *p = new Profile();
	Account *a = new Account();

	do
	{
		std::cout << std::endl
			<< " 1 - Create Profile.\n"
			<< " 2 - Story.\n"
			<< " 4 - Help.\n"
			<< " 5 - Exit.\n"
			<< " Enter your choice and press return: ";
		std::cin >> choice;

		switch (choice)
		{
		case 1:
			p->createProfile();
			break;
		case 2:
			a->createAccount();
			break;
		case 3:
			//code to make option for the game
			break;
		case 4:
			//code to help the user like give him
			//extra information about the mode and the controller 
			break;
		case 5:
			std::cout << "End of Program.\n";
			break;
		default:
			std::cout << "Not a Valid Choice. \n"
				<< "Choose again.\n";
			break;
		}

	} while (choice != 5);
    return 0;
}

