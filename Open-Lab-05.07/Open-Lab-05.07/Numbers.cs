using System;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            int smallest = 999999999;
            int pos = 0;
            
            int pos3 = 0;
            
            foreach (int i in nums)
            {
                pos++;
                if (i < smallest)
                {
                    smallest = i;
                    
                }

            }
            int[] final = new int[pos-1];
            foreach (int i in nums)
            {
                
                if (i > smallest)
                {
                    final[pos3] = i;
                    pos3++;
                }
                else
                {
                    smallest = -999999999;
                }

            }

            return final;
        }
    }
}
