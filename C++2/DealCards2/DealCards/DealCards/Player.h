#pragma once
#include <vector>
#include <string>

using namespace std;

class Player
{
public:
	Player();
	~Player();
	void addCardToPlayerHand(Player p, string card);
	
	string name;
	vector<string> hand;
};

