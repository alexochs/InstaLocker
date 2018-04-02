using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UITest;

namespace InstaLocker
{
    class Program
    {
        //mouse stuff
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        [STAThread]

        static void Main(string[] args)
        {
            //input champion name
            Console.Write("Champion (Press Enter): ");
            String champion = Console.ReadLine();
            Clipboard.SetText(champion);
            
            //wait for input to run script
            Console.WriteLine("\nPress a key to run script");
            Console.ReadKey();

            //click to get lol window in focus
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
            System.Threading.Thread.Sleep(50);

            //move cursor from corner to champion filter and click
            Cursor.Position = new Point(Cursor.Position.X + 977, Cursor.Position.Y + 128);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
            System.Threading.Thread.Sleep(100);

            //type in champion name
            SendKeys.SendWait("^V");
            System.Threading.Thread.Sleep(500); //der sleep is wichtig, da die champions erstmal gefiltert werden müssen

            //move cursor to champion and click
            Cursor.Position = new Point(Cursor.Position.X - 490, Cursor.Position.Y + 76);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
            System.Threading.Thread.Sleep(250);

            //move cursor to lock-in and click
            Cursor.Position = new Point(Cursor.Position.X + 319, Cursor.Position.Y + 552);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
            System.Threading.Thread.Sleep(100);

            //Chat Memes
            Cursor.Position = new Point(Cursor.Position.X - 656, Cursor.Position.Y + 80);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
            System.Threading.Thread.Sleep(100);
            Clipboard.SetText(">>> InstaLocker by yori x Battleju <<<");
            SendKeys.SendWait("^V");
            SendKeys.SendWait("{ENTER}");
        }
    }
}
