using System;

namespace Binary_Search{
    class BinarySearch{
        public Boolean search(int[] arr, int value){
            int low = 0;
            int high = arr.Length-1;

            while (low <= high){
                int middle = (low + high)/2;
                if(value < arr[middle]){
                    high = middle - 1;
                } else if(value > arr[middle]){
                    low = middle + 1;
                } else {
                    return true;
                }
            }
            return false;
        }
    }
}