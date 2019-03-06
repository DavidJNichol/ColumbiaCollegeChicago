// DealCards.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include "Player.h"
#include "Deck.h"
#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	Deck *deck = new Deck();
	Player *angelo = new Player();
	angelo->name = "Angelo";
	Player *rafael = new Player();;
	rafael->name = "Rafael";
	Player *steve = new Player();;
	steve->name = "Steve";
	Player *bagomeu = new Player();;
	bagomeu->name = "Bagomeu";

	Player *p[4]{ angelo, rafael, steve, bagomeu };	

	//Show name
	//shuffle the deck
	//deal a card and add to player's hand
	//delete the card that was dealed
	for (Player *player : p) {
		cout << player->name + " ";
		deck->shuffleDeck();
		for (int i = 0; i < 2; i++) {
			string card = deck->dealCard();
			player->hand.push_back(card);
			deck->deleteCard();
			cout << card << " ";
		}
		cout << endl;
	}

	cout << endl;
	cout << "Second Hand ! ";
	cout << endl << endl;

	for (Player *player : p) {
		cout << player->name + " ";
		deck->shuffleDeck();
		for (int i = 0; i < 3; i++) {
			string card = deck->dealCard();
			player->hand.push_back(card);
			deck->deleteCard();
			cout << card << " ";
		}
		cout << endl;
	}

	//The Trump
	cout << endl;
	cout << "Trump: ";
	deck->shuffleTrump();
	string trump = deck->dealTrump();
	cout << trump << " ";
	cout << endl << endl;

	string card = angelo->hand.at(1);
	cout << card << endl;

	
	for (Player *player : p) {
		for (int i = 0; i < 8; i++) {
			string card = player->hand[i];
			bool found = card.find(trump);
			if (found == true && card == "J" + trump) {
				
				cout << player->name + "will start playing";
			}else if (found == true && card == "K" + trump) {
				
				cout << player->name + "will start playing";
			}else if (found == true && card == "Q" + trump) {
				
				cout << player->name + "will start playing";
			}else if (found == true && card == "10" + trump) {
				
				cout << player->name + "will start playing";
			}
		}		
	}
		
	delete deck;
	delete rafael;
	delete angelo;
	delete steve;
	delete bagomeu;
	return 0;
	
}