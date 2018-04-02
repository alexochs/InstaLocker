using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InstaLocker
{
    class Program
    {
        static void Main(string[] args)
        {
            //input champion name
            Console.Write("Champion (Press Enter): ");
            String champion = Console.ReadLine();

            //move cursor from corner to champion filter and click

            //type in champion name

            //move cursor to champion and click

            //move cursor to lock-in and click
        }

        private void MoveCursor(int x, int y)
        {
            Cursor.Position = new Point(x, y);
        }
    }
}
