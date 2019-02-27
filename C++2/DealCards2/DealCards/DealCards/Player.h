#pragma once
#include <vector>
#include <string>

using namespace std;

class Player
{
public:
	Player();
	~Player();
private:
	string Name[4];
	vector<string> hand;
};

