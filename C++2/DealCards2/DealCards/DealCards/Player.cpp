#include "pch.h"
#include "Player.h"
#include <string>

Player::Player()
{
}


Player::~Player()
{
}

void Player::addCardToPlayerHand(Player p, string card) {
	
	p.hand.push_back(card);
}
