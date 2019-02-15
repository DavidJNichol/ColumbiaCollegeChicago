#include "pch.h"
#include "Deck.h"
#include <random>


Deck::Deck()
{
}

void Deck::shuffleDeck() {
	random_device random;
	mt19937 g(random());
	shuffle(deck.begin(), deck.end(), random);
}

void Deck::deleteCard() {
	deck.pop_back();
}

string Deck::dealCard() {;
	return deck.back();
}

Deck::~Deck()
{

}
