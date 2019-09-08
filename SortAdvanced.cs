namespace Algorthim
{
    static class SortAdvanced
    {
        public static int[] MergeSortRecursive(int[] input,int left,int right){
            if(left<right){
                var mid = (left+right)/2;
                var a =MergeSortRecursive(input,left,mid);
                var b =MergeSortRecursive(input,mid+1,right);
                var c =MergeTwoSort(a,b);
                return c;
            }else{
                return new int[] {input[left]};
            }
        }

        private static int[] MergeTwoSort(int[] a,int[] b){
            var c = new int [a.Length+b.Length];
            int i=0,j=0,k=0;

            while (i<a.Length&&j<b.Length)
            {
                if (a[i]<b[j])
                {
                    c[k++]=a[i++];
                }
                else
                {
                    c[k++]=b[j++];
                }
            }

            while (i<=a.Length-1)
            {
                c[k++]=a[i++];
            }

            while (j<=b.Length-1)
            {
                c[k++]=b[j++];
            }

            return c;
        }
    
        public static int[] MergeSortIterative(int[] input){
            var n = input.Length;

            for (int inc = 1; inc <= n; inc*=2)
            {
                for (int i = 0; i < n; i += 2*inc)
                {
                    var right = 0;
                    if(i+2*inc-1>n-1){
                        right = n-1;
                        if(i+inc-1>=right){
                            break;
                        }
                        MergeInSort(input,i,i+inc-1,right);                     
                    }else{
                        right = i+2*inc-1;
                        MergeInSort(input,i,i+inc-1,right);
                    }
                }
            }


            return input;
        }

        public static void MergeInSort(int[] input,int left,int mid,int right){
            if(left == right){
                return ;
            }
            var c = new int [right-left+1];
            int i=left,j=mid+1,k=0;

            while (i<=mid&&j<=right)
            {
                if (input[i]<input[j])
                {
                    c[k++]=input[i++];
                }
                else
                {
                    c[k++]=input[j++];
                }
            }

            while (i<=mid)
            {
                c[k++]=input[i++];
            }

            while (j<=right)
            {
                c[k++]=input[j++];
            }

            int z = left;
            int y = 0;
            while(y<k){
                input[z++] = c[y++];
            }
        }

        public static int[] QuickSortRecurisve(int[] input,int first,int last){
            if(first<last){
                var final = QuickSortHelper(input,first,last);
                QuickSortRecurisve(input,first,final);
                QuickSortRecurisve(input,final+1,last);
            }
            return input;
        }

        public static int QuickSortHelper(int[] input, int low, int high){
            var piovt = input[low];
            var flow = low;
            var fhigh =high;
            while (high>low)
            {
                while (low <=fhigh && input[low] <= piovt)
                {
                    low++;
                }

                while (high>0 && input[high] >= piovt)
                {
                    high--;
                }
                if(high>low){
                    var temp = input[low];
                    input[low] = input[high];
                    input[high] = temp;
                }
            }
            if(flow<high){
                input[flow] = input[high];
                input[high] = piovt;
                return high;
            }else{
                return flow;
            }
        }
    }
}
