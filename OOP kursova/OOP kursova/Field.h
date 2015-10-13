#include"TANK.h"
#include"enemy TANK.h"
class bField
{
	private:
		const int x , y;
		string mField[20][20];
	public:
		bField(const int x = 20 ,const int y = 20)
		{
			
			for(int i = 0;i<x;++i)
			{
				for(int j=0;j<y;++j)
				{
					mField[i][j] = " ";
				}
			}
		}
		~bField();
		void MoveTank(string field[][20] ,Tank bTank , eTank beTank , int x , int y);
		
};