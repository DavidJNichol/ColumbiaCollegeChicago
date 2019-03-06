#pragma once
#include <vector>
#include <string>

using namespace std;

class Deck
{
public:
	Deck();

	void shuffleDeck();
	void shuffleTrump();
	void sufflePlayerPosition();
	string dealCard();
	string dealTrump();
	int dealPlayerPosition();
	void deleteCard();
	
	
	~Deck();

private:
	vector<string> deck{"AS", "AH", "AC", "AD", "1S", "1H", "1C", "1D", "2S", "2H", "2C", "2D", "3S", "3H", "3C", "3D", "4S", "4H" ,"4C" ,"4D", "5S", "5H", "5C", "5D", "6S", "6H", "6C", "6D", "7S", "7H", "7C", "7D", "8S", "8H", "8C", "8D", "9S", "9H", "9C", "9D", "10S", "10H", "10C", "10D", "JS", "JH", "JC", "JD", "QS", "QH", "QC", "QD", "KS", "KH", "KC", "KD" };
	vector<string> trumps{ "S", "H", "C", "D" };
	vector<int> playerPosition{ 1, 2, 3, 4 };
};

