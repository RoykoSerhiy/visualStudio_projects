#include"TANK.h"
Tank::Tank(int hp = 100 , string t_sym = "|U|" , string b_sym = ".", bool is_e = false)
{
	HP=100;
	tanksymbol="|U|";
	bulletsymbol=".";
	isenemy = false;
}
Tank::~Tank()
{

}
void Tank::Shoot()
{

}
