/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class kadaneClass {
    static int Kadane(int[] arr)
    {
        //result is 0
        int res =0;
        //maxending sum = 0
        int maxEndingSum = 0;
        //iterate through array starting at 
        for(int i = 1; i< arr.Length; i++)
        {
            maxEndingSum = Math.Max(maxEndingSum + arr[i],arr[i]);
            res = Math.Max(res,maxEndingSum);
        }
        return res;
    }
  static void Main() {
      int[] arr = {2, 3, -8, 7, -1, 2, 3};
    Console.WriteLine(Kadane(arr));
  }
}