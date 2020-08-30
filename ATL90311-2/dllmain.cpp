// dllmain.cpp: реализация DllMain.

#include "pch.h"
#include "framework.h"
#include "resource.h"
#include "ATL903112_i.h"
#include "dllmain.h"

CATL903112Module _AtlModule;

// Точка входа DLL
extern "C" BOOL WINAPI DllMain(HINSTANCE hInstance, DWORD dwReason, LPVOID lpReserved)
{
	hInstance;
	return _AtlModule.DllMain(dwReason, lpReserved);
}
