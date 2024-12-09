using System;
using System.Security.Cryptography.X509Certificates;

class ArrayAsArgu{

    static int temp = 0;

    static void transpose(int[, ] arr) 
    { 
        for (int i = 0; i < arr.GetLength(0); i++) { 
            for (int j = i; j < arr.GetLength(1); j++) { 
                temp = arr[i, j]; 
                arr[i, j] = arr[j, i]; 
                arr[j, i] = temp; 
            } 
        } 
    }
    public static void myArrayasArg(){
        //  passed as arguments to the method.
        // A method can modify the value of the elements of the array. Both single-dimensional and multidimensional arrays can be passed as an argument to the methods.
        int[] arr = {1, 2, 3, 4};
        int[, ] ar;
        ar= new int[4, 4]{ { 1, 2, 3, 4}, 
                             { 5, 6, 7, 8}, 
                             {9, 10, 11, 12}, 
                             {13, 14, 15, 16} };
        
        Console.WriteLine("Matrix Before Transpose: ");
         for (int i = 0; i < ar.GetLength(0); i++) 
        { 
            for (int j = 0; j < ar.GetLength(1); j++) 
                Console.Write(ar[i, j] + " "); 
            Console.WriteLine(); 
        }
        transpose(ar);
        Console.WriteLine("Matrix After Transpose: ");
        for (int i = 0; i < ar.GetLength(0); i++) 
        { 
            for (int j = 0; j < ar.GetLength(1); j++) 
                Console.Write(ar[i, j] + " "); 
            Console.WriteLine(); 
        }
        // Result(arr);
    }
    public static void Result(int[] aa){
        foreach(int i in aa){
            Console.Write("{0} ",i);
        }
    }
}