using System;
using System.Linq;
using System.Threading;

namespace Algorthim
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 1000901;
            var input = Sort.SetInput(length, 40001);
            var input2 = new int[length];
            var input3 = new int[length];
            var input4 = new int[length];
            var input5 = new int[length];
            var input6 = new int[length];
            var input7 = new int[length];

            Array.Copy(input, input2, length);
            Array.Copy(input, input3, length);
            Array.Copy(input, input4, length);
            Array.Copy(input, input5, length);
            Array.Copy(input, input6, length);
            Array.Copy(input, input7, length);

            Thread SelectSort = new Thread(() => { Sort.SelectSort(input); System.Console.WriteLine("select"); });
            Thread BubbleSort = new Thread(() => { Sort.BubbleSort(input2); System.Console.WriteLine("bubble"); });
            Thread InsertSort = new Thread(() => { Sort.InsertSort(input3); System.Console.WriteLine("insert"); });
            Thread ShellSort = new Thread(() => { Sort.ShellSort(input4); System.Console.WriteLine("shell"); });
            Thread MergeSort1 = new Thread(() => { SortAdvanced.MergeSortRecursive(input5,0,input5.Length-1); System.Console.WriteLine("merge1"); });
            Thread MergeSort2 = new Thread(() => { SortAdvanced.MergeSortIterative(input6); System.Console.WriteLine("merge2"); });
            Thread QuickSort1 = new Thread(() => { SortAdvanced.QuickSortRecurisve(input7,0,input7.Length-1); System.Console.WriteLine("quick1"); });

            //BubbleSort.Start();
            //SelectSort.Start();
            //InsertSort.Start();
            //ShellSort.Start();
            MergeSort1.Start();
            MergeSort2.Start();
            QuickSort1.Start();
        }
    }
}
