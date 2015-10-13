#include"TANK.h"
class eTank: public Tank
{
	

	public:
		eTank(int hp, string t_sym , string b_sym, bool is_e);
		~eTank();
		void eShoot();
};