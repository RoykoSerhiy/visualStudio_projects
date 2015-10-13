//#include<windows.h>
//#include<string>
//#include<Windowsx.h>
//using namespace std;
//typedef basic_string<wchar_t> wString;
//#define IDTIMER 7
//LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM); 
//int WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
//{
//	HWND hMainWnd;	
//	wchar_t szClassName[] = L"MyClass";
//	MSG msg;
//	WNDCLASSEX wc;
//
//	wc.cbSize        = sizeof(wc);	
//	wc.style         = CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS;
//	wc.lpfnWndProc   = WndProc;
//	wc.cbClsExtra	 = 0;
//	wc.cbWndExtra    = 0;
//	wc.hInstance     = hInstance;
//	wc.hIcon         = LoadIcon(NULL, IDI_APPLICATION);
//	wc.hIconSm       = LoadIcon(NULL, IDI_APPLICATION);
//	wc.hCursor       = LoadCursor(NULL, IDC_HAND);
//	wc.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
//	wc.lpszMenuName  = NULL;
//	wc.lpszClassName = (LPCWSTR)szClassName;
//
//
//
//	if ( !RegisterClassEx( &wc ) ) {
//		MessageBox(NULL, L"Cannot register class", L"Error", MB_OK);
//		return 0;
//	}
//
//
//
//	hMainWnd = CreateWindow( 
//		szClassName,	
//		L"Press any key to manual",	
//		WS_OVERLAPPEDWINDOW,
//		CW_USEDEFAULT, 
//		0, 
//		CW_USEDEFAULT, 
//		0,
//		(HWND)NULL, 
//		(HMENU)NULL,
//		(HINSTANCE)hInstance, 
//		NULL
//		);
//
//
//	ShowWindow(hMainWnd, nCmdShow); 
//
//
//	while ( GetMessage( &msg, NULL, 0, 0) )  {
//		TranslateMessage(&msg);
//		DispatchMessage(&msg);
//	}
//
//	return msg.wParam;
//
//}
//
//
//LRESULT CALLBACK WndProc( HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam )
//{
//	HDC hDC;
//	PAINTSTRUCT ps; 
//	RECT rect; 
//	SYSTEMTIME SysTime;
//	static RECT rcTime;
//	wchar_t buf[256];
//	static wString aWeekday[7];
//	// static bool isfinish;
//
//	switch (msg)
//	{
//	case WM_CREATE:
//		{
//			aWeekday[0] = L"Неділя";
//			aWeekday[1] = L"Понеділок";
//			aWeekday[2] = L"Вівторок";
//			aWeekday[3] = L"ЧСереда";
//			aWeekday[4] = L"Четвер";
//			aWeekday[5] = L"Пятниця";
//			aWeekday[6] = L"Субота";
//
//			SetTimer(hWnd , IDTIMER , 1000 , NULL);
//
//			break;
//		}
//	case WM_TIMER:
//		{
//			InvalidateRect(hWnd , &rcTime , true);
//			break;
//		}
//	case WM_SIZE:
//		{
//			GetClientRect(hWnd , &rcTime);
//			return 0;
//		}
//	case WM_KEYDOWN:
//		{
//			MessageBox(hWnd , L"double klick remove clock , right mouse klick stop clock , left mouse click continue" ,  MB_OK , MB_ICONASTERISK);
//		}
//	case WM_RBUTTONDOWN:
//		{
//			KillTimer(hWnd , IDTIMER); 
//			break;
//		}
//	case WM_LBUTTONDOWN:
//		{
//			SendMessage(hWnd , WM_CREATE , wParam , lParam);
//			break;
//		}
//	case WM_LBUTTONDBLCLK:
//		{
//			int x = GET_X_LPARAM(lParam);
//			int y = GET_Y_LPARAM(lParam);
//			int ofsetX , ofsetY;
//			ofsetX =(rcTime.left+rcTime.right)/2;
//			ofsetY = (rcTime.bottom + rcTime.top)/2;
//			OffsetRect(&rcTime , x-ofsetX , y-ofsetY);
//			SendMessage(hWnd , WM_PAINT  , wParam , lParam);
//			InvalidateRect(hWnd , &rect , true);
//			break;
//		}
//	case WM_PAINT:
//		hDC = BeginPaint(hWnd, &ps);
//
//		GetSystemTime(& SysTime);
//		wsprintf(buf , L"%s, %02i.%02i.%02i , %02i:%02i:%02i ",aWeekday[SysTime.wDayOfWeek].c_str(), SysTime.wDay , SysTime.wMonth , SysTime.wYear , SysTime.wHour , SysTime.wMinute , SysTime.wSecond);
//		DrawText(hDC , buf , -1 , &rcTime , DT_CENTER|DT_VCENTER|DT_SINGLELINE);
//
//		EndPaint(hWnd, &ps);
//		return 0;
//
//	case WM_CLOSE:
//		DestroyWindow(hWnd);
//		return 0;
//
//	case WM_DESTROY:
//		PostQuitMessage(0);
//		return 0;
//
//
//
//
//	default:
//		return DefWindowProc(hWnd, msg, wParam, lParam);
//	}
//
//	return 0;
//}