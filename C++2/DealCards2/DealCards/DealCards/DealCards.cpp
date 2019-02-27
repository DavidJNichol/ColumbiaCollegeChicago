// DealCards.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include "Player.h"
#include "Deck.h"
#include <iostream>

using namespace std;

int main()
{
	string Name[4]{ "Angelo", "Rafael", "Steve", "Bagomeu" };
	Deck *deck = new Deck();
	 
	for (string player : Name) {
		cout << player + " ";
		deck->shuffleDeck();
		for (int i = 0; i < 2; i++) {
			string card = deck->dealCard();
			deck->deleteCard();
			cout << card << " ";
		}
		cout << endl;
	}

	cout << endl;
	cout << "Second Hand ! ";
	cout << endl << endl;

	for (string player : Name) {
		cout << player + " ";
		deck->shuffleDeck();
		for (int i = 0; i < 3; i++) {
			string card = deck->dealCard();
			deck->deleteCard();
			cout << card << " ";
		}
		cout << endl;
	}

	string lastCard = deck->dealCard();
	deck->deleteCard();
	cout << "Last Card : " << lastCard << endl;

	//Decide the Player
	cout << endl;
	cout << "Player: ";
	deck->sufflePlayerPosition();
	int pPosition = deck->dealPlayerPosition();
	for (int i = 0; i < 1; i++) {
		cout << Name[pPosition];
	}

	//The Trump
	cout << endl;
	cout << "Trump: ";
	deck->shuffleTrump();
	string trump = deck->dealTrump();
	cout << trump << " ";
	cout << endl << endl;

	delete deck;
	return 0;
	
}