using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "AntiArithmetic", typeof(List<int>))]
    [System.Runtime.InteropServices.Guid("80C42F9C-94A7-4276-AAF1-890F33C2C66A")]
    public class AntiArithmetic
    {
        public List<int> Go()
        {
            int countnumber = 0;
            int[] array = new int[0];
            List<int> lisSequence = new List<int>();
            Tokenizer tok = new Tokenizer();

            while (true)
            {
                string tokenVal = tok.ReadLine();
                if (tokenVal.Trim() == "0")
                {
                    return new List<int>();
                }
                string[] split = tokenVal.Split(new char[] { ':' }, StringSplitOptions.None);
                countnumber = Int32.Parse(split[0]);
                split = split[1].Trim().Split(new char[] { ' ' }, StringSplitOptions.None);
                array = split.Select(Int32.Parse).ToArray(); //Array.ConvertAll(split, int.Parse);
                bool res = check(array, countnumber);
                Console.WriteLine(res ? "no" : "yes");
            }
        }
        // 5: 0 5 8 3 1 45 - is wrong
        //  3: 0 2 1
        //5: 2 0 3 1 4
        //6: 2 4 3 5 0 1
        private static bool check(int[] array, int countNumber)
        {
            int arrayLength = array.Length;
            int d=-10000;
            for (int j = 0; j < arrayLength; j++)
            {
                if (j == arrayLength - 1)
                {
                    return false;
                }
                for (int i = j+1; i < arrayLength; i++)
                {
                    int dif = array[i] - array[j];
                    if (dif == 2 * d)
                    {
                        return true;
                    }
                    d = dif;
                }
                d = -10000;
            }

            return false;
        }

        private List<int> getWhereRes(bool isDiff, List<int> interarray, int cmprs, int j)
        {
            if (isDiff)
            {
                return interarray.Where(x => x == cmprs - j).ToList();
            }
            else
            {
                return interarray.Where(x => x == cmprs + j).ToList();
            }
        }
    }

    //bool breakingsecond = false;
    //for (int j = 0; j < array.Length;)
    //{
    //    breakingsecond = false;
    //    if (j == array.Length - 1) break;
    //    if (lisSequence.Count == 0)
    //    {
    //        lisSequence.Add(array[j]);
    //    }
    //    for (int i = j + 1; i < array.Length; i++)
    //    {
    //        if (array[i] - array[j] != 1) continue;
    //        j = i;
    //        lisSequence.Add(array[i]);
    //        breakingsecond = true;
    //        break;
    //    }
    //    if (lisSequence.Count == 3) break;
    //    if (breakingsecond)
    //    {
    //        continue;
    //    }
    //    j++;

    //    lisSequence.Clear();
    //}


    //BufferedStdoutWriter buff = new BufferedStdoutWriter();
    //while ((line = Console.ReadLine()) != null)
    //{

    //    while (tok.HasNext())
    //    {
    //        line = tok.Next();
    //        line = line.Trim();
    //        if (line.Length == 1) continue;
    //        string[] split = line.Split(new char[] {':'}, StringSplitOptions.None);
    //        split = split[1].Trim().Split(new char[] {' '}, StringSplitOptions.None);
    //        array = Array.ConvertAll(split, int.Parse);

    //        bool breakingsecond = false;
    //        for (int j = 0; j < array.Length;)
    //        {
    //            breakingsecond = false;
    //            if (j == array.Length - 1) break;
    //            if (lisSequence.Count == 0)
    //            {
    //                lisSequence.Add(array[j]);
    //            }
    //            for (int i = j + 1; i < array.Length; i++)
    //            {
    //                if (array[i] - array[j] != 1) continue;
    //                j = i;
    //                lisSequence.Add(array[i]);
    //                breakingsecond = true;
    //                break;
    //            }
    //            if (lisSequence.Count == 3) break;
    //            if (breakingsecond)
    //            {
    //                continue;
    //            }
    //            j++;

    //            lisSequence.Clear();
    //        }
    //        buff.WriteLine(lisSequence.Count == 3 ? "no" : "yes");
    //        break;
    //    }
    //}

    //return resList;





    public class NoMoreTokensException : Exception
    {
    }

    public class Tokenizer
    {
        string[] tokens = new string[0];
        private int pos;
        StreamReader reader;

        public Tokenizer(Stream inStream)
        {
            var bs = new BufferedStream(inStream);
            reader = new StreamReader(bs);
        }

        public Tokenizer() : this(Console.OpenStandardInput())
        {
            // Nothing more to do
        }

        public string ReadLine()
        {
            return reader.ReadLine();
        }
        private string PeekNext()
        {
            if (pos < 0)
                // pos < 0 indicates that there are no more tokens
                return null;
            if (pos < tokens.Length)
            {
                if (tokens[pos].Length == 0)
                {
                    ++pos;
                    return PeekNext();
                }
                return tokens[pos];
            }
            string line = reader.ReadLine();
            if (line == null)
            {
                // There is no more data to read
                pos = -1;
                return null;
            }
            // Split the line that was read on white space characters
            tokens = line.Split(null);
            pos = 0;
            return PeekNext();
        }

        public bool HasNext()
        {
            return (PeekNext() != null);
        }

        public string Next()
        {
            string next = PeekNext();
            if (next == null)
                throw new NoMoreTokensException();
            ++pos;
            return next;
        }
    }

    public class Scanner : Tokenizer
    {

        public int NextInt()
        {
            return int.Parse(Next());
        }

        public long NextLong()
        {
            return long.Parse(Next());
        }

        public float NextFloat()
        {
            return float.Parse(Next());
        }

        public double NextDouble()
        {
            return double.Parse(Next());
        }
    }


    public class BufferedStdoutWriter : StreamWriter
    {
        public BufferedStdoutWriter() : base(new BufferedStream(Console.OpenStandardOutput()))
        {
        }
    }
}



