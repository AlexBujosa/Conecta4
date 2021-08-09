using System;
using System.Threading;
using System.Collections.Generic;
namespace Conecta4
{
    class Conect4
    {
        public string player = "";
        bool firstPlayerPlay = true;
        public bool Game = true;
        string[,] PlayerMarks = new string[7, 6];
        string[] Mark = { "O", "X" };
        bool value = false;
        int PositionMarkX = 0;
        int PositionMarkY = 0;
        public int Desea = 0;
        /*
        Posiciones de la consola del Conecta 4
        |2,3|4,3|6,3|8,3|10,3|12,3|14,3|
        |2,4|4,4|6,4|8,4|10,4|12,4|14,4|
        |2,5|4,5|6,5|8,5|10,5|12,5|14,5|
        |2,6|4,6|6,6|8,6|10,6|12,6|14,6|
        |2,7|4,7|6,7|8,7|10,7|12,7|14,7|
        |2,8|4,8|6,8|8,8|10,8|12,8|14,8|
         Posiciones del array del conecta 4
        |0,5|1,5|2,5|3,5|4,5|5,5|6,5|
        |0,4|1,4|2,4|3,4|4,4|5,4|6,4|
        |0,3|1,3|2,3|3,3|4,3|5,3|6,3|
        |0,2|1,2|2,2|3,2|4,2|5,2|6,2|
        |0,1|1,1|2,1|3,1|4,1|5,1|6,1|
        |0,0|1,0|2,0|3,0|4,0|5,0|6,0|
        */
        public void Decisionkey(char Key)
        {
            switch (Key)
            {
                case '1':
                    (PositionMarkX, PositionMarkY, value) = CheckColumn(0);
                    if (value)
                        Markbox(2, PositionMarkX, PositionMarkY);
                    else
                        MessageAlert();
                    break;
                case '2':
                    (PositionMarkX, PositionMarkY, value) = CheckColumn(1);
                    if (value)
                        Markbox(4, PositionMarkX, PositionMarkY);
                    else
                        MessageAlert();
                    break;
                case '3':
                    (PositionMarkX, PositionMarkY, value) = CheckColumn(2);
                    if (value)
                        Markbox(6, PositionMarkX, PositionMarkY);
                    else
                        MessageAlert();
                    break;
                case '4':
                    (PositionMarkX, PositionMarkY, value) = CheckColumn(3);
                    if (value)
                        Markbox(8, PositionMarkX, PositionMarkY);
                    else
                        MessageAlert();
                    break;
                case '5':
                    (PositionMarkX, PositionMarkY, value) = CheckColumn(4);
                    if (value)
                        Markbox(10, PositionMarkX, PositionMarkY);
                    else
                        MessageAlert();
                    break;
                case '6':
                    (PositionMarkX, PositionMarkY, value) = CheckColumn(5);
                    if (value)
                        Markbox(12, PositionMarkX, PositionMarkY);
                    else
                        MessageAlert();
                    break;
                case '7':
                    (PositionMarkX, PositionMarkY, value) = CheckColumn(6);
                    if (value)
                        Markbox(14, PositionMarkX, PositionMarkY);
                    else
                        MessageAlert();
                    break;
            }
        }
        public bool CheckWin(string Mark)
        {
            bool checkingwin = false;
            for(int i = 0; i<7; i++)
            {
                for(int j = 0;j<6;j++)
                {
                    if (PlayerMarks[i, j] == Mark)
                    {
                        if (j < 3)
                        {
                            for (int a = 0; a < 4; a++)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i, j + a]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 3)
                                    return checkingwin;
                            }
                        }
                        if (j > 2)
                        {
                            for (int a = 3; a > 0; a--)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i, j - a]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 1)
                                    return checkingwin;
                            }
                        }
                        if (i < 3)
                        {
                            for (int a = 0; a < 4; a++)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i + a, j]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 3)
                                    return checkingwin;
                            }
                        }
                        if (i > 3)
                        {
                            for (int a = 3; a > 0; a--)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i - a, j]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 1)
                                    return checkingwin;
                            }
                        }
                        if (i == 3)
                        {
                            for (int a = 0; a < 4; a++)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i + a, j]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 3)
                                    return checkingwin;
                            }
                            for (int a = 3; a > 0; a--)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i - a, j]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 1)
                                    return checkingwin;
                            }
                        }
                        if (j < 3 && i < 4)
                        {
                            for (int a = 1; a < 4; a++)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i + a, j + a]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 3)
                                    return checkingwin;
                            }
                        }
                        if (j > 2 && i < 4)
                        {
                            for (int a = 1; a < 4; a++)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i + a, j - a]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 3)
                                    return checkingwin;
                            }
                        }
                        if (j < 3 && i > 2)
                        {
                            for (int a = 1; a < 4; a++)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i - a, j + a]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 3)
                                    return checkingwin;
                            }

                        }
                        if (j > 2 && i > 2)
                        {
                            for (int a = 1; a < 4; a++)
                            {
                                checkingwin = (PlayerMarks[i, j] == PlayerMarks[i - a, j - a]);
                                if (!checkingwin)
                                    break;
                                else if (checkingwin == true && a == 3)
                                    return checkingwin;
                            }
                        }
                    }
                }
            }
            return checkingwin;
        }
        public void ChangePlay()
        {
            if (firstPlayerPlay)
                firstPlayerPlay = false;
            else
                firstPlayerPlay = true;
        }
        public (int , int , bool) CheckColumn(int Position)
        {
            for(int i = 0; i<6; i++)
            {
                if (string.IsNullOrEmpty(PlayerMarks[Position, i]))
                {
                    return (Position, i,true);
                }
            }
            return (0,0,false);
        }
        public void Markbox(int position, int PositionMarkX, int PositionMarkY)
        {
            PlayerMarks[PositionMarkX, PositionMarkY] = Mark[Convert.ToInt32(firstPlayerPlay)];
            Console.SetCursorPosition(position, 8 - PositionMarkY);
            Console.Write(Mark[Convert.ToInt32(firstPlayerPlay)]);
            Game = !CheckWin(Mark[Convert.ToInt32(firstPlayerPlay)]);
            if (Mark[Convert.ToInt32(firstPlayerPlay)] == "X")
                player = "Player 1";
            else if (Desea == 2 && Mark[Convert.ToInt32(firstPlayerPlay)] == "O")
                player = "Computer";
            else
                player = "Player 2";
            ChangePlay();
                
        }
        public void MessageAlert()
        {
            Console.SetCursorPosition(20, 5);
            Console.Write("You cannot play in that column, it is already complete");
            Thread.Sleep(3000);
            Console.SetCursorPosition(20, 5);
            Console.Write("                                                       ");
        }
        public void writeTable()
        {
            for (int i = 3; i <= 8; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
                Console.SetCursorPosition(3, i);
                Console.Write("|");
                Console.SetCursorPosition(5, i);
                Console.Write("|");
                Console.SetCursorPosition(7, i);
                Console.Write("|");
                Console.SetCursorPosition(9, i);
                Console.Write("|");
                Console.SetCursorPosition(11, i);
                Console.Write("|");
                Console.SetCursorPosition(13, i);
                Console.Write("|");
                Console.SetCursorPosition(15, i);
                Console.Write("|");
            }
            for (int i = 1; i < 16; i++)
            {
                Console.SetCursorPosition(i, 9);
                Console.Write("\u25A0");
            }

        }
        public void LogicGame()
        {
            if(Desea == 2 && firstPlayerPlay == false)
            {
                ComputerThinking();
                ComputerLogic();
            }
            else if(Desea == 1 || (Desea == 2 && firstPlayerPlay == true))
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Keyinfo = new ConsoleKeyInfo();
                    Keyinfo = Console.ReadKey(true);
                    char key = Keyinfo.KeyChar;
                    Decisionkey(key);
                }
            }
        }
        //Computer Play
        //Computer thinking
        public void ComputerThinking()
        {
            Console.SetCursorPosition(20, 5);
            Console.Write("Wait, Computer is thinking");
            Thread.Sleep(3000);
            Console.SetCursorPosition(20, 5);
            Console.Write("                          ");
        }
        
        public int Conect()
        {
            string XMark = "X";
            string OMark = "O";
            //Vertical Conect 3 to 4 MarkO
            for (int j = 0; j < 7;j++)
            {
                int i = 0;
                while (i < 3)
                {
                    if(PlayerMarks[j, i] == PlayerMarks[j, i + 1] && PlayerMarks[j,i] == PlayerMarks[j, i + 2] && PlayerMarks[j, i+3] == null && PlayerMarks[j, i] == OMark)
                    {
                        return j + 1;
                    }
                    i++;
                }
            }
            //Horizontal Conect 3 to 4 MarkO
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(PlayerMarks[j,i] == PlayerMarks[j + 1,i] && PlayerMarks[j, i] == PlayerMarks[j + 2, i] && PlayerMarks[j + 3, i] == null && PlayerMarks[j,i] == OMark)
                    {
                        return j + 4;
                    }
                    if (PlayerMarks[j + 1, i] == null && PlayerMarks[j, i] == PlayerMarks[j + 2, i] && PlayerMarks[j, i] == PlayerMarks[j + 3, i] && PlayerMarks[j, i] == OMark)
                    {
                        return j + 2;
                    }
                    if (PlayerMarks[j, i] == PlayerMarks[j + 1, i] && PlayerMarks[j + 2, i] == null && PlayerMarks[j, i] == PlayerMarks[j + 3, i] && PlayerMarks[j, i] == OMark)
                    {
                        return j + 3;
                    }
                    if(PlayerMarks[j,i] == null && PlayerMarks[j + 1, i] == PlayerMarks[j + 2, i] && PlayerMarks[j + 1, i] == PlayerMarks[j + 3, i] && PlayerMarks[j + 1, i] == OMark)
                    {
                        return j + 1;
                    }
                }
            }
            //Vertical Conect 3 to 4 MarkX
            for (int j = 0; j < 7; j++)
            {
                int i = 0;
                while (i < 3)
                {
                    if (PlayerMarks[j, i] == PlayerMarks[j, i + 1] && PlayerMarks[j, i] == PlayerMarks[j, i + 2] && PlayerMarks[j, i + 3] == null && PlayerMarks[j, i] == XMark)
                    {
                        return j + 1;
                    }
                    i++;
                }
            }
            //Vertical Conect 2 to 3 MarkO
            for (int j = 0; j < 7; j++)
            {
                int i = 0;
                while (i < 3)
                {
                    if (PlayerMarks[j, i] == PlayerMarks[j, i + 1] && PlayerMarks[j, i + 2]  == null && PlayerMarks[j, i] == OMark)
                    {
                        return j + 1;
                    }
                    i++;
                }
            }


            return 0;
        }
        public void ComputerLogic()
        {
            List<string> columnAvaible = FindColumnNoComplete();
            int countAvaible = columnAvaible.Count;
            Random rnd = new Random();
            int value = rnd.Next(0, countAvaible);
            if(Conect() == 0)
                Decisionkey(char.Parse(columnAvaible[value]));
            else
            {
                Decisionkey(char.Parse(Conect().ToString()));
            }
        }
        public List<string> FindColumnNoComplete()
        {
            List<string> ColumnAvaible = new List<string>();
            for(int i = 0; i <7;i++)
            {
                for(int j = 0; j<6; j++)
                {
                    if(PlayerMarks[i,j] == null)
                    {
                        ColumnAvaible.Add((i + 1).ToString());
                        break;
                    }
                }
            }
            return ColumnAvaible;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Write("How you want to play with two players or with CPU? Option1: 2 Player and Option2: CPU ");
            Conect4 Conecta = new Conect4();
            Conecta.Desea = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.CursorVisible = false;
            Conecta.writeTable();
            while (Conecta.Game)
            {
                Conecta.LogicGame();
                Console.CursorVisible = false;
             
            }
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("The player {0} win", Conecta.player);
            Thread.Sleep(10000);
            Console.Clear();
            Console.Write("Do you want to play again? ");
            string ask = Console.ReadLine();
            Console.Clear();
            if (ask.ToUpper() == "YES")
                goto start;
            Console.ReadKey();
        }
    }
    
}
