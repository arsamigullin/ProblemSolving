using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Count Luck", typeof(List<int>))]
    class CountLuck
    {
        public List<int> Go()
        {
            ReadingTestCases.ReadAllText();
            int T = Int32.Parse(ReadingTestCases.ReadLine());
            while (T>0)
            {
                T--;
                int[] nm = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), Int32.Parse);
                int N = nm[0];
                int M = nm[1];
                char [][] forest = new char[N][];
                Coordinate portkey = new Coordinate();
                Coordinate startPosition = new Coordinate();
                List<Coordinate> turningCoordinates = new List<Coordinate>();
                List<Coordinate> neuboList = new List<Coordinate>
                {
                    new Coordinate(1,0),
                    new Coordinate(-1,0),
                    new Coordinate(0,1),
                    new Coordinate(0,-1)
                };
                bool [,] visited = new bool[N,M];
               // visited[startPosition.N, startPosition.M] = true;
                for (int i = 0; i < N; i++)
                {
                    string s = ReadingTestCases.ReadLine();
                    for (int j = 0; j < M; j++)
                    {
                        if (s[j] == '*')
                        {
                            portkey.N = i;
                            portkey.M = j;
                        }
                        if (s[j] == 'M')
                        {
                            startPosition.N = i;
                            startPosition.M = j;
                        }
                    }
                    forest[i] = s.ToCharArray();
                }
                int K = Int32.Parse(ReadingTestCases.ReadLine());
                int total = 0;
                bst(forest, neuboList, startPosition, portkey, visited, N, M, ref total);
                Console.WriteLine(total == K ? "Impressed" : "Oops!");
            }
            return new List<int>();
        }

        struct Coordinate
        {
            public Coordinate(int n, int m)
            {
                N = n;
                M = m;
            }
            public int N;
            public int M;
        }

        bool bst(char[][] a, List<Coordinate> neuboList, Coordinate startCoordinate, Coordinate portkey, bool[,] visited, int n, int m, ref int total)
        {
            if (startCoordinate.N < 0 || startCoordinate.M < 0 || startCoordinate.N >= n || startCoordinate.M >= m || visited[startCoordinate.N,startCoordinate.M])
            {
                return false;
            }

            bool result = true;
            for (int i = startCoordinate.N; i < n; i++)
            {
                for (int j = startCoordinate.M; j < m; j++)
                {
                    if (a[i][j] == 'X') return false;
                    if (a[i][j] == 'Y') return false;
                    a[i][j] = 'Y';
                    if (i == portkey.N && j == portkey.M)
                    {
                        return true;
                    }
                    int count = 0;
                    for (int k = 0; k < neuboList.Count; k++)
                    {
                        Coordinate start = new Coordinate(i + neuboList[k].N, j + neuboList[k].M);
                        if (start.N < 0 || start.M < 0 || start.N >= n || start.M >= m || visited[start.N, start.M])
                        {
                            continue;
                        }
                        if (a[start.N][start.M]=='.' || a[start.N][start.M] == '*')
                        {
                            count++;
                        }
                    }
                    
                    for (int k = 0; k < neuboList.Count; k++)
                    {
                        Coordinate start = new Coordinate(i+neuboList[k].N, j+neuboList[k].M);
                        if (bst(a, neuboList, start, portkey, visited, n, m, ref total))
                        {
                            if (count > 1)
                            {
                                total++;
                            }
                            visited[startCoordinate.N, startCoordinate.M] = true;
                            return true;
                        }
                    }
                  
                }
            }
            return false;
        }
    }
}
