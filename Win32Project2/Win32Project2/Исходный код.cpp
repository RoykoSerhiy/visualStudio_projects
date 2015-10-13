#include<windows.h>
#include<string>
#include<Windowsx.h>
#include<ctime>
using namespace std;
typedef basic_string<wchar_t> wString;
#define IDTIMER 7
#define TIMER_MOVE 17
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM); 
void moveTimer(HWND hWnd ,RECT &rect ,int ofsetX ,  int ofsetY);

int WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
	HWND hMainWnd;	
	wchar_t szClassName[] = L"MyClass";
	MSG msg;
	WNDCLASSEX wc;

	wc.cbSize        = sizeof(wc);	
	wc.style         = CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS;
	wc.lpfnWndProc   = WndProc;
	wc.cbClsExtra	 = 0;
	wc.cbWndExtra    = 0;
	wc.hInstance     = hInstance;
	wc.hIcon         = LoadIcon(NULL, IDI_APPLICATION);
	wc.hIconSm       = LoadIcon(NULL, IDI_APPLICATION);
	wc.hCursor       = LoadCursor(NULL, IDC_HAND);
	wc.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
	wc.lpszMenuName  = NULL;
	wc.lpszClassName = (LPCWSTR)szClassName;



	if ( !RegisterClassEx( &wc ) ) {
		MessageBox(NULL, L"Cannot register class", L"Error", MB_OK);
		return 0;
	}



	hMainWnd = CreateWindow( 
		szClassName,	
		L"Press any key to manual",	
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT, 
		0, 
		CW_USEDEFAULT, 
		0,
		(HWND)NULL, 
		(HMENU)NULL,
		(HINSTANCE)hInstance, 
		NULL
		);


	ShowWindow(hMainWnd, nCmdShow); 


	while ( GetMessage( &msg, NULL, 0, 0) )  {
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return msg.wParam;

}


LRESULT CALLBACK WndProc( HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam )
{
	HDC hDC;
	PAINTSTRUCT ps; 
	static RECT rClient; 
	srand(unsigned(time(0)));
	SYSTEMTIME SysTime;
	static RECT rcTime;
	RECT rcOld = rcTime;
	
	wchar_t buf[256];
	static wString aWeekday[7];
	static bool key = false;
	// static bool isfinish;
	static int iStepX , iStepY;
	switch (msg)
	{
	case WM_CREATE:
		{
			aWeekday[0] = L"Неділя";
			aWeekday[1] = L"Понеділок";
			aWeekday[2] = L"Вівторок";
			aWeekday[3] = L"ЧСереда";
			aWeekday[4] = L"Четвер";
			aWeekday[5] = L"Пятниця";
			aWeekday[6] = L"Субота";

			SetTimer(hWnd , IDTIMER , 1000 , NULL);

			break;
		}
	case WM_TIMER:
		{
			
			switch(wParam)
			{
			case IDTIMER:
				{
					
					hDC = GetDC(hWnd);
					POINT ptOld;
					ptOld.x= rcTime.left;
					ptOld.y = rcTime.top;
					GetSystemTime(& SysTime);
					wsprintf(buf , L"%s, %02i.%02i.%02i , %02i:%02i:%02i ",aWeekday[SysTime.wDayOfWeek].c_str(), SysTime.wDay , SysTime.wMonth , SysTime.wYear , SysTime.wHour , SysTime.wMinute , SysTime.wSecond);
					DrawText(hDC , buf , -1 , &rcTime , DT_CENTER|DT_VCENTER|DT_SINGLELINE|DT_CALCRECT);
					//OffsetRect(&rcTime , ptOld.x , ptOld.y);
					rcTime.left= ptOld.x;
					rcTime.top=ptOld.y;
					InvalidateRect(hWnd , &rcTime , true);
					ReleaseDC(hWnd , hDC);
					break;
				}
			case TIMER_MOVE:
				{
					
					moveTimer(hWnd ,rcTime ,iStepX ,  iStepY);
					if(rcTime.left<=rClient.left||rcTime.right>=rClient.right)
					{
						iStepX*=-1;
					}
					if(rcTime.bottom>=rClient.bottom||rcTime.top<=rClient.top)
					{
						iStepY*=-1;
					}
				}
			}
			
			break;
		}
	case WM_SIZE:
		{
			GetClientRect(hWnd , &rClient);
			GetClientRect(hWnd , &rcTime); 
			return 0;
		}
	case WM_KEYDOWN:
		{
			MessageBox(hWnd , L"double klick remove clock , right mouse klick stop clock , left mouse click continue" ,  MB_OK , MB_ICONASTERISK);
		}
	case WM_RBUTTONDOWN:
		{
			if(key == false)
			{

				KillTimer(hWnd , IDTIMER); 
				key = true;
			}
			else
			{
				SendMessage(hWnd , WM_CREATE , wParam , lParam);
				key = false;
			}


			break;
		}

	case WM_LBUTTONDOWN:
		{
			RECT rectTemp;
			int x = GET_X_LPARAM(lParam);
			int y = GET_Y_LPARAM(lParam);
			int ofsetX , ofsetY;
			ofsetX =(rcTime.left+rcTime.right)/2;
			ofsetY = (rcTime.bottom + rcTime.top)/2;
			OffsetRect(&rcTime , x-ofsetX , y-ofsetY);
			//SendMessage(hWnd , WM_PAINT  , wParam , lParam);


			UnionRect(&rectTemp , &rcTime , &rcOld);
			InvalidateRect(hWnd , &rectTemp , true);
			break;
		}
	case WM_LBUTTONDBLCLK:
		{
			SetTimer(hWnd , TIMER_MOVE , 100 , NULL);
			iStepX = -10+rand()%11;
			iStepY = -10+rand()%11;
			break;
		}
	case WM_PAINT:
		hDC = BeginPaint(hWnd, &ps);

		GetSystemTime(& SysTime);
		wsprintf(buf , L"%s, %02i.%02i.%02i , %02i:%02i:%02i ",aWeekday[SysTime.wDayOfWeek].c_str(), SysTime.wDay , SysTime.wMonth , SysTime.wYear , SysTime.wHour , SysTime.wMinute , SysTime.wSecond);
		DrawText(hDC , buf , -1 , &rcTime , DT_CENTER|DT_VCENTER|DT_SINGLELINE);

		EndPaint(hWnd, &ps);
		return 0;

	case WM_CLOSE:
		DestroyWindow(hWnd);
		return 0;

	case WM_DESTROY:
		PostQuitMessage(0);
		return 0;




	default:
		return DefWindowProc(hWnd, msg, wParam, lParam);
	}

	return 0;
}



void moveTimer(HWND hWnd ,RECT &rect ,int ofsetX ,  int ofsetY)
{
			RECT rcOld , rectInvalid;
			rcOld = rect;
			OffsetRect(&rect , ofsetX , ofsetY);
			rectInvalid = rect;
			UnionRect( &rectInvalid, &rect , &rcOld);
			InvalidateRect(hWnd , &rectInvalid , true);
}