using System;

namespace Algorthim
{
    public static class Sort
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
