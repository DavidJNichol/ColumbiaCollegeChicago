#pragma once
#include<string>
#include<vector>

class Order
{
public:
	Order();
	~Order();

	double o_bill;
	std::vector<std::string> o_foods;
};

