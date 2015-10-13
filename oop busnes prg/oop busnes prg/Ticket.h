#include<iostream>
#include<ctime>
#include<Windows.h>
#include<string>
using namespace std;
class Tiket
{
	public:
		string MoveWith;
		string MoveTo;
		double distance;
		
	public:
		Tiket()
		{
		};
		Tiket(string MW , string MT , double dist)
		{
			MoveWith = MW;
			MoveTo = MT;
			distance = dist;
			
		};
		~Tiket()
		{
		};
		void Show()
		{
			cout<<"Move With: "<<MoveWith<<"\n";
			cout<<"Move To: "<<MoveTo<<"\n";
			cout<<"Distance: "<<distance<<"\n";
			
		};


};