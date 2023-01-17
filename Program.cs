using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1; //1 = X and 2 = O

    static void Main()
    {
        //Initialize the game board
        DrawBoard();

        while (true)
        {
            //Player input
            Console.WriteLine("Player {0}, enter a number:", player);
            int choice = int.Parse(Console.ReadLine());


            {
                //Validate input
                if (choice >= 1 && choice <= 9)
                {
                    if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
                    {
                        if (player == 1)
                        {
                            board[choice - 1] = 'X';
                            player = 2;
                        }
                        else
                        {
                            board[choice - 1] = 'O';
                            player = 1;
                        }
                        DrawBoard();
                        if (CheckWin())
                        {
                            Console.WriteLine("Player {0} wins!", player);
                            break;
                        }
                        if (CheckDraw())
                        {
                            Console.WriteLine("Draw!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Slot already taken. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }

        static void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
        }

        static bool CheckWin()
        {
            if (board[0] == board[1] && board[1] == board[2]) return true;
            if (board[3] == board[4] && board[4] == board[5]) return true;
            if (board[6] == board[7] && board[7] == board[8]) return true;
            if (board[0] == board[3] && board[3] == board[6]) return true;
            if (board[1] == board[4] && board[4] == board[7]) return true;
            if (board[2] == board[5] && board[5] == board[8]) return true;
            if (board[0] == board[4] && board[4] == board[8]) return true;
            if (board[2] == board[4] && board[4] == board[6]) return true;
            return false;

        }

        static bool CheckDraw()
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i] != 'X' && board[i] != 'O') return false;
            }
            return true;
        }
    }
}
