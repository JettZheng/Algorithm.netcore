using System;
using System.Threading;

namespace Algorthim
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Sort.SetInput(40000,40000);
            var input2 = new int[40000];
            var input3 = new int[40000];
            var input4 = new int[40000];
            Array.Copy(input,input2,40000);
            Array.Copy(input,input3,40000);
            Array.Copy(input,input4,40000);
            Thread SelectSort = new Thread(()=>{Sort.SelectSort(input);System.Console.WriteLine("select");});
            Thread BubbleSort = new Thread(()=>{Sort.BubbleSort(input2);System.Console.WriteLine("bubble");});
            Thread InsertSort = new Thread(()=>{Sort.InsertSort(input3);System.Console.WriteLine("insert");});
            Thread ShellSort = new Thread(()=>{Sort.ShellSort(input4);System.Console.WriteLine("shell");});

            SelectSort.Start();
            BubbleSort.Start();
            InsertSort.Start();
            //ShellSort.Start();

            //Sort.SelectSort(input);
            //Sort.BubbleSort(input);
            //Sort.InsertSort(input);
            //Sort.ShellSort(input);
        }
    }
    
    static class Sort{
        public static int[] SetInput(int length,int lessthan){
            var output = new int[length];
            var random = new Random();
            while(length>0){
                output[length-1] = random.Next(lessthan);
                length--;
            }
            return output;
        }

        public static int[] SelectSort(int[] input){
            var n = input.Length;
            int min;
            for (int i = 0; i < n; i++)
            { 
                min = input[i];
                for (int j = i+1; j < n; j++)
                {
                    if(min>input[j]){
                        min = input[j];
                        input[j] = input[i];
                    }
                }
                input[i]=min;
            }
            return input;
        }

        public static int[] BubbleSort(int[] input){
            var n = input.Length;
            int temp;
            for (int i = 1; i < n; i++)
            {
                for (int j = i-1; j >=0; j--)
                {
                    if (input[j]>input[j+1])
                    {
                     temp = input[j+1];
                     input[j+1]= input[j];
                     input[j]=temp;
                    }else{
                        break;
                    }
                }
            }
            return input;
        }

        public static int[] InsertSort(int[] input){
            var n = input.Length;
            int temp;
            for (int i = 1; i < n; i++)
            {
                temp = input[i];
                for (int j = i-1;j>=0; j--)
                {
                    if(input[j]>temp){
                        input[j+1] = input[j];
                        if(j==0){
                            input[0] = temp;
                        }
                    }else{
                        input[j+1] = temp;
                        break;
                    }
                }
            }
            return input;
        }

        public static int[] ShellSort(int[] input){
            var length = input.Length;
            for (int gap = length/2; gap >1; gap=gap/2)
            {
                for (int i = 0; i < gap; i++)
                {
                    if(input[i]>input[gap]){
                        var temp = input[gap];
                        input[gap]= input[i];
                        input[i] = temp;
                    }
                }
            }
            return input;
        }

        
    }
}
