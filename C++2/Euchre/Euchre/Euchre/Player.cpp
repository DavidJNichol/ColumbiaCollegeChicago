#include "pch.h"
#include "Player.h"
#include <string>
#include <cassert>
#include <cstdlib>
#include <string>
#include <algorithm>

using namespace std;

static const string name[]{"Angelo", "Rafael", "Bruno", "Bagomeu"};

Player::Player()
{
	_name = 0;
}

Player::Player(int name)
{
	_name = name;
}

string Player::getName() const{
	return name[_name % 4];
}

Player::~Player()
{
}
