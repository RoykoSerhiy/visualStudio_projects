#include"enemy TANK.h"
eTank::eTank(int hp = 100 , string t_sym = "|O|" , string b_sym = ".", bool is_e = true)
{
	HP=hp;
	tanksymbol=t_sym;
	bulletsymbol=b_sym;
	isenemy = is_e;
}
eTank::~eTank()
{

}
void eTank::eShoot()
{

}