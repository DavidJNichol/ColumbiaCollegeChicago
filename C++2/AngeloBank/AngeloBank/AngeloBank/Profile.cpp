#include "stdafx.h"
#include "Profile.h"
#include <iostream>


Profile::Profile()
{
}


Profile::~Profile()
{
}

void Profile::createProfile()
{
	this->ID++;

	std::cout << "Username: ";
	std::string name;
	std::cin >> name;
	profiles[ID].User = name;

	std::cout << "Addres: ";
	std::string address;
	std::cin >> address;
	profiles[ID].Address = address;

	
}
