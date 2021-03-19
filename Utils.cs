using System;
using System.Collections.Generic;
using System.Text;

namespace Rx.Console
{
    public static class Utils
    {
        public static void PrintColoredMessage(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine(message);
            System.Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
