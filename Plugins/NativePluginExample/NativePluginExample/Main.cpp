#include <Windows.h>

#define UNITY_INTERFACE_API __stdcall
#define UNITY_INTERFACE_EXPORT __declspec(dllexport)

extern "C"
{

UNITY_INTERFACE_EXPORT int UNITY_INTERFACE_API GetNumber()
{
    return 123;
}

UNITY_INTERFACE_EXPORT int UNITY_INTERFACE_API DoSomething(int x, int y)
{
    const int x2 = x * 2;
    const int y3 = y * 3;
    return x2 * y3;
}

UNITY_INTERFACE_EXPORT BOOL UNITY_INTERFACE_API NpeSetCursorPos(int x, int y)
{
    return ::SetCursorPos(x, y);
}

}