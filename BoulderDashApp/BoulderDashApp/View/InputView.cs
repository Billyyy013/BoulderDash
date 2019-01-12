﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.View
{
    class InputView
    {
        public void AskForArrowInput()
        {
            Console.WriteLine("Gebruik de pijltjes toetsen.");
        }

        public ConsoleKey RetrieveConsoleKey()
        {
            ConsoleKey key = Console.ReadKey().Key;
            return key;
        }

        public void InvalidInputMessage()
        {
            Console.Write("Invalide input");
        }

        public int AskForLevelNumber()
        {
            Console.WriteLine("Press 1 - 3 to start a level");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
