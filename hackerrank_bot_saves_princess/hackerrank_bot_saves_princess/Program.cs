using System;
using System.Collections.Generic;
using System.Text;


namespace hackerrank_bot_saves_princess
{
    class Program
    {
        struct Point{
        public int x,y;
        
        }
        static void displayPathtoPrincess(int n, String [] grid)
        {
            Point p,m;
            p.x = p.y = m.x = m.y = 0;
            for(int i = 0;i<n;i++)
                for(int j = 0;j<n;j++)
                {
                    if(grid[i][j]=='p')
                    {p.x = i;p.y = j;}
                    if(grid[i][j]=='m')
                    {m.x = i;m.y = j;}
                    
                }
            int gapx = m.x - p.x; int gapy = m.y - p.y;
            if (gapx < 0)
                for (int i = 0; i < -gapx; i++)
                    Console.WriteLine("DOWN");
            else
                for (int i = 0; i < gapx; i++)
                    Console.WriteLine("UP");
            if (gapy < 0)
                for (int i = 0; i < -gapy; i++)
                    Console.WriteLine("RIGHT");
            else
                for (int i = 0; i < gapy; i++)
                    Console.WriteLine("LEFT");
                
        }

        static void Main(String[] args)
        {
            int m;

            m = int.Parse(Console.ReadLine());

            String[] grid  = new String[m];
            for(int i=0; i < m; i++) {
                grid[i] = Console.ReadLine(); 
            }

            displayPathtoPrincess(m, grid); Console.ReadKey();
            }
        }
    }

