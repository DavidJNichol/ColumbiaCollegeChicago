#pragma once
#include <string>
#include <cassert>
#include <cstdlib>
#include <string>
#include <algorithm>

using namespace std;

class Player
{
	public:
		Player(int name);
		Player();		
		string getName() const;
		~Player();

	private:
		int _name;
		static const string name[];
};

