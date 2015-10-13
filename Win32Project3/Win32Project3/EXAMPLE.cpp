//#include "ex00_Menu.h"
//
//
//MainMenu	MENU
//{
//	MENUITEM	"&File",		IDM_File
//	MENUITEM	"&Edit",		IDM_Edit
//
//	MENUITEM	"&Garayed",		IDM_Grayed,		GRAYED
//	MENUITEM	"&Inactive",	IDM_Inactive,	INACTIVE
//
//	MENUITEM	"&Activate",	IDM_Activate
//	MENUITEM SEPARATOR
//
//	// вкладене меню
//	POPUP		"&PopUp"
//	{
//		MENUITEM	"&Activate",	IDM_Activate
//		MENUITEM	"&Activate",	IDM_Activate	// можна використовувати менюітеми, котрі посилають однакові команди
//		MENUITEM	"&Deactivate",	IDM_Inactive
//
//	}// POPUP		"&PopUp"
//
//
//	// багаторівневе  меню
//	POPUP		"PopUp - вк&лaдене"
//	{
//		// вкладене меню
//		POPUP		"&Activate"
//		{
//			MENUITEM	"Activate Garayed",		IDM_ActivateGray
//			MENUITEM	"Activate Inactive",	IDM_ActivateInact
//			MENUITEM SEPARATOR
//			MENUITEM	"Deactivate Garayed",	IDM_DeactivateGray
//			MENUITEM	"Deaivate Inactive",	IDM_DeactivateInact
//
//		}// POPUP		"&Activate"
//		MENUITEM	"&Add Deactivation",		IDM_AddDeactivation
//
//	}// POPUP		"&PopUp"
//
//
//	POPUP			"Checked Items"
//	{
//		MENUITEM	"Item1"		IDM_Checked1	,CHECKED
//		MENUITEM	"Item2"		IDM_Checked2
//		MENUITEM	"Item3"		IDM_Checked3
//
//	}// POPUP			"Checked Items"
//
//
//	POPUP			"Radio Items"
//	{
//		MENUITEM	"Item1"		IDM_Radio1		//,CHECKED
//		MENUITEM	"Item2"		IDM_Radio2
//		MENUITEM	"Item3"		IDM_Radio3
//
//	}// POPUP			"Checked Items"
//
//
//	MENUITEM	"e&Xit",		IDM_Exit,		HELP
//	MENUITEM	"&Help",		IDM_Help
//
//
//}