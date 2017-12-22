using UnityEngine;

namespace NativePluginExample
{

public class CallDllFunction : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Lib.DoSomething(3, 5));

        // Win32API.SetCursorPos(100, 100);
        Lib.SetCursorPos(100, 100);
    }
}

}