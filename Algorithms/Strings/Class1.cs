using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void go(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        int N = arr[0];
        int M = arr[1];
        int min = Math.Min((N%2 == 0 ? (N/2 - 1) : N/2), (M%2 == 0 ? (M/2 - 1) : M/2));
        List<char[]> area = new List<char[]>();
        bool[,] alr = new bool[N,M];
        int count = N;
        while (count > 0)
        {
            area.Add(Console.ReadLine().ToCharArray());
            count--;
        }
        int first = searh(area, ref alr, min, M, N);
        int second = searh(area, ref alr, min, M, N);
        Console.WriteLine(first*second);

    }

    static int searh(List<char[]> area, ref bool[,] alr, int min, int M, int N)
    {
        int maxLen = 0;
        int countGood = 0;
        int cnt = 1;
        int singleM = -1;
        int singleN = -1;
        bool[,] tempalr = new bool[N, M];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (area[i][j] == 'B')
                    continue;
                if (alr[i,j]) continue;

                countGood++;
                if (singleM < 0 && singleN < 0)
                {
                    singleM = j;
                    singleN = i;
                }
                List<Point> lp = new List<Point>();
                while (cnt <= min)
                {
                    if (i + cnt >= N) break;
                    if (i - cnt < 0) break;
                    if (j + cnt >= M) break;
                    if (j - cnt < 0) break;
                    if (alr[i + cnt,j] || alr[i - cnt,j] || alr[i,j + cnt] || alr[i,j - cnt]) break;
                    lp.Add(new Point(i, j));
                    lp.Add(new Point(i + cnt, j));
                    lp.Add(new Point(i - cnt, j));
                    lp.Add(new Point(i, j + cnt));
                    lp.Add(new Point(i, j - cnt));
                    /*tempalr[i][j]=true;
                    tempalr[i][j+cnt]=true;
                    tempalr[i][j-cnt]=true;
                    tempalr[i+cnt][j]=true;
                    tempalr[i-cnt][j]=true;*/
                    cnt++;
                }
                if (maxLen < cnt)
                {
                    maxLen = cnt;
                    tempalr = new bool[N, M];
                    for (int k = 0; k < lp.Count; k++)
                    {
                        tempalr[lp[i].I,lp[i].J] = true;
                    }
                }
            }
        }



        alr = tempalr;
        if (maxLen == 1 && countGood > 0)
        {
            alr[singleN,singleM] = true;
            return 1;
        }
        return cnt*4 + 1;
    }
}


struct Point
{
    public Point(int i, int j)
    {
        I = i;
        J = j;
    }
    public int I;
    public int J;
}
