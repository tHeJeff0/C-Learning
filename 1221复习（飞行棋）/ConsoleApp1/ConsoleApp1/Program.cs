using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] Maps = new int[100];
        public static int[] PlayerPos = new int[2];
        public static string[] PlayerName = new string[2];
        public static bool[] isPause = new bool[2];
        static void Main(string[] args)
        {
            GameTitle();
           
            Console.WriteLine("请输入玩家A的名字");
            PlayerName[0] = Console.ReadLine();
            while (PlayerName[0] == "")
            {
                Console.WriteLine("玩家名不能为空，请重新输入");
                PlayerName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的名字");
            PlayerName[1] = Console.ReadLine();
            while (PlayerName[1] == PlayerName[0] || PlayerName[1] == "")
            {
                if (PlayerName[1] == PlayerName[0])
                {
                    Console.WriteLine("玩家名不能相同,重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家名不能为空,请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
            }

            Console.Clear();

            GameTitle();
            InitialMap();
            DrawMap();
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                PlayGame(0);
                Console.ReadKey();
                PlayGame(1);
                Console.ReadKey();
                Console.Clear();

                GameTitle();
                InitialMap();
                DrawMap();

                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了", PlayerName[0]);
                }
                else
                {
                    Console.WriteLine("玩家{0}赢了", PlayerName[1]);

                }

            }
            
            Console.ReadKey();
        }

        public static void GameTitle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********12.21飞行棋项目*******");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************");
        }

        public static void InitialMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运转盘Ｏ
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道※
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }

        public static void DrawMap()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawMapString(i));
            }
            Console.WriteLine();

            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(DrawMapString(i));                
            }

            for (int i = 35; i < 65; i++)
            {
                Console.Write(DrawMapString(i));
            }
            Console.WriteLine();

            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine(DrawMapString(i));
            }
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawMapString(i));
            }
            Console.WriteLine();

        }

        public static string DrawMapString(int i)
        {
            string s = "";
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
            {
                s="<>";
            }
            else if (PlayerPos[0] == i)
            {
                s="Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                s="Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        s="□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        s="Ｏ";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        s="☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        s="▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        s="※";
                        break;
                }
            }
            return s;
        }

        public static void PlayGame(int playerN)
        {
            if (isPause[playerN] == false)
            {
                Random dice = new Random();
                int number = dice.Next(1, 7);
                PlayerPos[playerN] += number;
                Console.WriteLine("掷出{0},玩家{1}前进{2}格",number, PlayerName[playerN], number);
                switch (Maps[PlayerPos[playerN]])
                {
                    case 0:
                        Console.WriteLine("踩到方块，一滴事都无");
                        break;
                    case 1:
                        Console.WriteLine("踩到幸运转盘，请选择一个执行:1--让玩家[0]后退6格子，2--和玩家[1]交换位置", PlayerName[1 - playerN], PlayerName[1 - playerN]);
                        string input = Console.ReadLine();
                        if (input == "1")
                        {
                            PlayerPos[1 - playerN] -= 6;
                        }
                        if (input == "2")
                        {
                            int temp = PlayerPos[playerN];
                            PlayerPos[1 - playerN] = temp;
                            PlayerPos[playerN] = PlayerPos[1 - playerN];
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到地雷，后退6格", PlayerName[playerN]);
                        PlayerPos[playerN] -= 6;
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到障碍物，暂停一回合", PlayerName[playerN]);
                        Barrier(playerN);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到时空隧道，前进10格", PlayerName[playerN]);
                        PlayerPos[playerN] += 10;
                        break;
                }
            }
            else
            {
                isPause[playerN] = false;
            }
        }

        public static bool Barrier(int playerN)
        {
            if (isPause[playerN] == false)
            {
                isPause[playerN] = true;
                return isPause[playerN];
            }
            else
            {
                return isPause[playerN];
            }
            
        }
    }
}
