#include "pch.h"
#include "Card.h"
#include <string>
#include <string>
#include <cassert>
#include <cstdlib>
#include <string>
#include <algorithm>

using namespace std;

const string Card::card_faces[] = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
const string Card::card_suits[] = { "S", "H", "C", "D" };

Card::Card()
{
	_card = 0;
}

Card::Card(int card) {
	_card = card;
}

string Card::getFace() const {
	return card_faces[_card % 13];
}

string Card::getSuit() const {
	return card_suits[_card / 13];
}
