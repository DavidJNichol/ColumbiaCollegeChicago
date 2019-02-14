#pragma once
#ifndef DECK_H
#define DECK_H
#include "Card.h"
#include <string>
#include <cassert>
#include <cstdlib>
#include <string>
#include <algorithm>

using namespace std;

class Deck
{
	public:
		Deck();

		Card dealOneCard();
		void shuffle();

	private:
		Card _cards[52];
		int _nextCardIndex;
};

#endif