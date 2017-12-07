using System;

namespace Sequential_Search
{
    class SequentialSearch{
        public Boolean search(int[] arr, int value){
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==value){
                    return true;
                }
            }
            return false;
        }
    }
}