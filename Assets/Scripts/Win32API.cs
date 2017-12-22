using System.Runtime.InteropServices;

namespace NativePluginExample
{

static public class Win32API
{
    [DllImport("user32.dll")]
    public static extern int SetCursorPos(int x, int y);
}

}