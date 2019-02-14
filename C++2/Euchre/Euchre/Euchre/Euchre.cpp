#include "pch.h"
#include "card.h"
#include "deck.h"
#include "player.h"
#include <iostream>
#include <cstdlib>
#include <ctime>
#include <string>

using namespace std;

int main()
{
	int numOfCards;
	srand(time(0));
	Deck deck;
	string name[]{ "Angelo", "Rafael", "Bruno", "Bagomeu" };
	
	while (cin >> numOfCards) {
		for (string player : name) {
			deck.shuffle();
			cout << "Your hand " + player + " is: ";
			for (int cardNum = 0; cardNum < numOfCards; cardNum++) {
				Card c = deck.dealOneCard();
				string suit = c.getSuit();
				string face = c.getFace();
				cout << face << suit << " ";
			}
			cout << endl;
		}
		
	}
	
	

	return 0;
}
