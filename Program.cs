using System;
using System.Threading;

namespace Algorthim
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 8;
            var input = Sort.SetInput(length, 8);
            var input2 = new int[length];
            var input3 = new int[length];
            var input4 = new int[length];

            Array.Copy(input, input2, length);
            Array.Copy(input, input3, length);
            Array.Copy(input, input4, length);

            Thread SelectSort = new Thread(() => { Sort.SelectSort(input); System.Console.WriteLine("select"); });
            Thread BubbleSort = new Thread(() => { Sort.BubbleSort(input2); System.Console.WriteLine("bubble"); });
            Thread InsertSort = new Thread(() => { Sort.InsertSort(input3); System.Console.WriteLine("insert"); });
            Thread ShellSort = new Thread(() => { Sort.ShellSort(input4); System.Console.WriteLine("shell"); });

            SelectSort.Start();
            BubbleSort.Start();
            InsertSort.Start();
            ShellSort.Start();

            //Sort.SelectSort(input);
            //Sort.BubbleSort(input);
            //Sort.InsertSort(input);
            //Sort.ShellSort(input);
        }
    }

    static class Sort
    {
        public static int[] SetInput(int length, int lessthan)
        {
            var output = new int[length];
            var random = new Random();
            while (length > 0)
            {
                output[length - 1] = random.Next(lessthan);
                length--;
            }
            return output;
        }

        public static int[] SelectSort(int[] input)
        {
            var n = input.Length;
            int min;
            for (int i = 0; i < n; i++)
            {
                min = input[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (min > input[j])
                    {
                        min = input[j];
                        input[j] = input[i];
                    }
                }
                input[i] = min;
            }
            return input;
        }

        public static int[] BubbleSort(int[] input)
        {
            var n = input.Length;
            int temp;
            for (int i = 1; i < n; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (input[j] > input[j + 1])
                    {
                        temp = input[j + 1];
                        input[j + 1] = input[j];
                        input[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return input;
        }

        public static int[] InsertSort(int[] input)
        {
            var n = input.Length;
            int temp;
            for (int i = 1; i < n; i++)
            {
                temp = input[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (input[j] > temp)
                    {
                        input[j + 1] = input[j];
                        if (j == 0)
                        {
                            input[0] = temp;
                        }
                    }
                    else
                    {
                        input[j + 1] = temp;
                        break;
                    }
                }
            }
            return input;
        }

        public static int[] ShellSort(int[] input)
        {
            var length = input.Length;
            for (int gap = length / 2; gap >= 1; gap /= 2)
            {
                for (int i = 0; i < gap; i++)
                {
                    for (int j = i + gap; j < length; j += gap)
                    {
                        var temp = input[j];
                        for (int k = j - gap; k >= i; k -= gap)
                        {
                            if (input[k] > temp)
                            {
                                input[k + gap] = input[k];
                                if (k == i)
                                {
                                    input[i] = temp;
                                }
                            }
                            else
                            {
                                input[k + gap] = temp;
                                break;
                            }
                        }
                    }
                }
            }
            return input;
        }


    }
}
