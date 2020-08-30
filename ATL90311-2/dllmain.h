// dllmain.h: объявление класса модуля.

class CATL903112Module : public ATL::CAtlDllModuleT< CATL903112Module >
{
public :
	DECLARE_LIBID(LIBID_ATL903112Lib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_ATL903112, "{27a829d0-963a-4618-af8e-b5b578c200ec}")
};

extern class CATL903112Module _AtlModule;
