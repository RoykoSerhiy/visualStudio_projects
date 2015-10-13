#include<iostream>
#include<ctime>
#include<Windows.h>
#include<string>
#include"Ticket.h"
using namespace std;
class TicketTrain : public Tiket
{
	public:
		int vagon_n;
		int kupe_n;
		double price;
	public:
		TicketTrain(int _vagon_n , int _kupe_n , double pr)
		{
			vagon_n = _vagon_n;
			kupe_n = _kupe_n;
			price = pr;
		};

};