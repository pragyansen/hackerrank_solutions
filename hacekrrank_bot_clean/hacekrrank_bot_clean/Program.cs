using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace hacekrrank_bot_clean
{
    class Program
    {
        static void next_move(int posr, int posc, string[] tempboard)
        {
            string fileName = "myfile.txt";
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            string s = sr.ReadToEnd();
            file.Close();
            string[] board;
            if (!string.IsNullOrEmpty(s))
            {
                string[] datafile = s.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                board = merge(tempboard, datafile);
                /*  file.Close();
                  //The file is empty. Write something to it
                  //Console.WriteLine( "file doesn't exist " );
                  file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                  StreamWriter sw = new StreamWriter(file);
                  for (int i = 0; i < tempboard.Length; i++)
                      sw.WriteLine(tempboard[i]);
                  sw.Close(); */
            }
            else
            {
                board = new string[tempboard.Length];
                for (int i = 0; i < tempboard.Length; i++)
                {
                    board[i] = tempboard[i];
                }

            }












            double mindis = board.Length * board[0].Length; int x=0, y=0;
            bool dirty_cell_found = false;
            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[i].Length; j++)
                {
                    double distance;
                    if (board[i][j] == 'd')
                    {
                        dirty_cell_found = true;
                        distance = calc_dis(posr, posc, i, j);
                        if (mindis > distance)
                        { mindis = distance; x = i; y = j; }
                    }
                }
            if (dirty_cell_found)
            {
                int gapx = posr - x; int gapy = posc - y;
                if (gapx == 0 && gapy == 0)
                    Console.WriteLine("CLEAN");
                else if (gapx < 0)
                    //      for (int i = 0; i < -gapx; i++)
                    Console.WriteLine("DOWN");
                else if (gapx > 0)
                    //      for (int i = 0; i < gapx; i++)
                    Console.WriteLine("UP");
                else if (gapy < 0)
                    //      for (int i = 0; i < -gapy; i++)
                    Console.WriteLine("RIGHT");
                else
                    //      for (int i = 0; i < gapy; i++)
                    Console.WriteLine("LEFT");

            }
            else find_next_cell(posr, posc, board);


            file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            for (int i = 0; i < board.Length; i++)
                sw.WriteLine(board[i]);
            sw.Close(); 
        }

        private static void find_next_cell(int posr, int posc, string[] board)
        {
            double mindis = board.Length * board[0].Length; int x = 0, y = 0;
            bool dirty_cell_found = false;
            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[i].Length; j++)
                {
                    double distance;
                    if (board[i][j] == 'o')
                    {
                        dirty_cell_found = true;
                        distance = calc_dis(posr, posc, i, j);
                        if (mindis > distance)
                        { mindis = distance; x = i; y = j; }
                    }
                }
            if (dirty_cell_found)
            {
                int gapx = posr - x; int gapy = posc - y;
                if (gapx == 0 && gapy == 0)
                    Console.WriteLine("CLEAN");
                else if (gapx < 0)
                    //      for (int i = 0; i < -gapx; i++)
                    Console.WriteLine("DOWN");
                else if (gapx > 0)
                    //      for (int i = 0; i < gapx; i++)
                    Console.WriteLine("UP");
                else if (gapy < 0)
                    //      for (int i = 0; i < -gapy; i++)
                    Console.WriteLine("RIGHT");
                else
                    //      for (int i = 0; i < gapy; i++)
                    Console.WriteLine("LEFT");

            }
        }

        private static string[] merge(string[] board, string[] datafile)
        {
            StringBuilder[] final = new StringBuilder[board.Length];
            string[] merge = new string[board.Length];
            for (int row = 0; row < board.Length; row++)
            {
                final[row] = new StringBuilder();
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] == 'o' && datafile[row][col] != 'o')
                        final[row].Append(datafile[row][col]);
                    else
                    {
                        final[row].Append(board[row][col]);
                    }
                }
                merge[row] = final[row].ToString();
            }

            return merge;
        }

        private static float calc_dis(int posr, int posc, int i, int j)
        {
            return (posr - i) * (posr - i) + (posc - j) * (posc - j);
        }
        /* Tail starts here */
        static void Main(String[] args)
        {
            String temp = Console.ReadLine();
            String[] position = temp.Split(' ');
            int[] pos = new int[2];
            String[] board = new String[5];
            for (int i = 0; i < 5; i++)
            {
                board[i] = Console.ReadLine();
            }
            for (int i = 0; i < 2; i++) pos[i] = Convert.ToInt32(position[i]);
    /*        int[,] data = new int[board.Length,board[0].Length];
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'b')
                        data[i, j] = '1';
                    else if (board[i][j] == '-')
                        data[i, j] = '0';
                    else if(boar
                }
            }
            
      */      
            next_move(pos[0], pos[1], board);


           
        }
    }
}