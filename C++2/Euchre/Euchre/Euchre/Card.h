#pragma once
#include <string>
#include <cassert>
#include <cstdlib>
#include <string>
#include <algorithm>

#ifndef CARD_H
#define CARD_H

using namespace std;

class Card
{
	public:
		Card(int card);
		Card();
		string getSuit() const;
		string getFace() const;

	private:
		int _card;

		static const string card_faces[];
		static const string card_suits[];
};

#endif