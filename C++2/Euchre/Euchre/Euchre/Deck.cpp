#include "pch.h"
#include "Deck.h"
#include "Card.h"
#include <cassert>
#include <cstdlib>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

Deck::Deck()
{
	for (int i = 0; i < 52; i++) {
		_cards[i] = Card(i);
	}
	shuffle();
	_nextCardIndex = 0;
}

Card Deck::dealOneCard() {
	assert(_nextCardIndex >= 0 && _nextCardIndex < 52);
	return _cards[_nextCardIndex++];
}

void Deck::shuffle() {
	// Shuffle by exchanging each element randomly
	for (int i = 0; i < (52 - 1); i++) {
		int randnum = i + (rand() % (52 - i));
		swap(_cards[i], _cards[randnum]);
	}
	_nextCardIndex = 0;
}