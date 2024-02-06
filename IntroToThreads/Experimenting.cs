using System.Runtime.InteropServices;
using System.Text;
using HWND = System.IntPtr;

namespace IntroToThreads
{
    internal static class Experimenting
    {
        private delegate bool EnumWindowProc(IntPtr hwnd, IntPtr lParam);
        
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        private static extern IntPtr GetDesktopWindow();

        [DllImport("USER32.DLL")]
        private static extern IntPtr GetShellWindow();

        [DllImport("USER32.DLL")]
        private static extern int GetWindowText(HWND hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowTextLength(HWND hWnd);

        private static void GetDesktopWindows()
        {
            HWND shell = GetShellWindow();
            HWND des = GetDesktopWindow();
            List<string> list = new List<string>();
            Experimenting.
                        EnumChildWindows(des, (hwnd, lParam) =>
                        {
                            try
                            {
                                if (hwnd == shell) return true;

                                var length = Experimenting.GetWindowTextLength(hwnd);
                                if (length == 0) return true;

                                StringBuilder builder = new StringBuilder();
                                Experimenting.GetWindowText(hwnd, builder, length + 10);


                                list.Add(builder.ToString());
                                Console.WriteLine(builder.ToString());
                            }
                            catch (Exception ex)
                            {

                                throw ex;
                            }

                            return true;
                        }, 0);

        }
    }
}