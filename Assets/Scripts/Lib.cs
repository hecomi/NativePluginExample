using System.Runtime.InteropServices;

namespace NativePluginExample
{

static public class Lib
{
    [DllImport("NativePluginExample")]
    public static extern int GetNumber();

    [DllImport("NativePluginExample")]
    public static extern int DoSomething(int x, int y);

    [DllImport("NativePluginExample", EntryPoint = "NpeSetCursorPos")]
    public static extern void SetCursorPos(int x, int y);
}

}