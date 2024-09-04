using BakingApp.Services;

namespace BankingApp.Views
{
    internal class AppInterface
    {
        private readonly AppServices _appServices;

        public AppInterface(AppServices appServices)
        {
            _appServices = appServices;
        }

        public void MenuDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Select one of the options below:");
            Console.ResetColor();

            Console.WriteLine("Use up and down arrows to navigate and press Enter to select\n");

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
            switch (option)
            {
                case 1:
                    _appServices.ShowCurrentBalance();
                    break;
                case 2:
                    Console.WriteLine("Enter recipient name:");
                    string recipient = Console.ReadLine();
                    Console.WriteLine("Enter amount to transfer:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                    {
                        _appServices.TransferFunds(recipient, amount);
                    }
                    break;
                case 3:
                    _appServices.ShowCardDetails();
                    break;
            }
        }
    }
}
