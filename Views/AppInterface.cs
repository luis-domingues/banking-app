using BankingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Views
{
    internal class AppInterface
    {
        public void MenuDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Select one of the options below:");
            Console.ResetColor();

            Console.WriteLine("Use up and down arrows to navigate and press \u001b[32mEnter/Return\u001b[0m key to select\n");

            ConsoleKeyInfo key;
            int selectOption = 1;
            bool isSelected = false;
            (int left, int top) = Console.GetCursorPosition();
            string color = "\u001b[32m> ";
            Console.CursorVisible = false;
            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                Console.WriteLine($"{(selectOption == 1 ? color : "  ")}View current account balance\u001b[0m");
                Console.WriteLine($"{(selectOption == 2 ? color : "  ")}Bank transfer area\u001b[0m");
                Console.WriteLine($"{(selectOption == 3 ? color : "  ")}Details my card\u001b[0m");

                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        selectOption = (selectOption == 3 ? 1 : selectOption + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        selectOption = (selectOption == 1 ? 3 : selectOption - 1);
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                }
            }
            Console.Clear();
            ExecuteOption(selectOption);
        }

        private void ExecuteOption(int option)
        {
            AppServices appServices = new AppServices();
            
            switch(option)
            {
                case 1:
                    appServices.ViewCurrentAccountBalance();
                    break;
                case 2:
                    appServices.BankTransferArea();
                    break;
                case 3:
                    Console.WriteLine("Wait! New updates are coming soon...");
                    break;
            }
        }
    }
}