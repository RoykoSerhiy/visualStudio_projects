#include<iostream>
#include<ctime>
#include<Windows.h>
#include<string>
using namespace std;
class Tank
{	
	private:
		int HP;
		string tanksymbol;
		string bulletsymbol;
		bool isenemy;
	public:
		Tank(int hp, string t_sym, string b_sym , bool is_e);
		~Tank();
		void Shoot();

};