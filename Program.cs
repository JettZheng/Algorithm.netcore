using System;

namespace Algorthim
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Sort.SetInput(8,8);
            //Sort.SelectSort(input);
            Sort.BubbleSort(input);
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
                        //after select shold swap not only replace
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
