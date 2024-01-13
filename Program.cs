using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sorta{
    class Program {
        static void Main(string [] args) {
            int [] array = { 9943, 43, 34, 1, 24, 4, 11};

            MergeSort(array);
            
            for(int i = 0; i< array.Length; i++) {
                Console.Write($"{array[i]} ");
            }

        }
        public static void MergeSort(int [] array){
            
            int length = array.Length;
            
            if(length<=1) return; // never forget the base case
            int middle = array.Length/2;

            int [] leftArray = new int[middle];
            int [] rightArray = new int[length-middle];

            int i = 0;
            int j = 0;
            for(; i<length; i++){
                if(i < middle){
                    leftArray[i] = array[i];
                } else {
                    rightArray[j] = array[i];
                    j++;
                }
            }
        
        MergeSort(leftArray);
        MergeSort(rightArray);
        Merge(leftArray, rightArray, array);

        } 
        public static void Merge(int [] leftArray, int [] rightArray, int [] array) {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;

            int left = 0;
            int right = 0;
            int i = 0;
            
            while(left < leftSize && right < rightSize){
                if(leftArray[left]< rightArray[right]){
                    array[i]= leftArray[left];
                    left++;
                    i++;
                } else {
                    array[i] = rightArray[right];
                    i++;
                    right++;
                }
            }

            while (left< leftSize){
                 array[i]= leftArray[left];
                    left ++;
                    i++;
            }

            while (right< rightSize) {
                array[i] = rightArray[right];
                    i++;
                    right++;

            }

        }
    }
}