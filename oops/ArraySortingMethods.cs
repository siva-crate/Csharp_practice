using System;
using System.Collections.Generic;

class Sort1
{
    public static void Mysort1() 
    { 
        // array elements 
        string[] arr = new string[6] { "A",  
                      "D", "X", "G", "M","C" };
        
        Array.Sort(arr); 
        Console.WriteLine("\nAfter Sort:");
         foreach(string g in arr) 
        { 
            Console.WriteLine(g); 
             
        }
        Console.WriteLine("\nB sorts between :");
        int idx = Array.BinarySearch(arr, "E");
        Console.WriteLine(idx);
        sortT(arr, idx);
    }
        public static void sortT<T>(T[] arr, int index) 
    { 
                if (index < 0) { 
              
            index = ~index; 
  
            if (index == 0) 
                Console.Write("beginning of array"); 
            else
                Console.Write("{0} and ", arr[index - 1]); 
  
            if (index == arr.Length) 
                Console.WriteLine("end of array."); 
            else
                Console.WriteLine("{0}", arr[index]); 
        } 
    } 

    }
    // Sort<T>(T[], IComparer<T>) Method
    class CustomCompare : IComparer<string>{
            public int Compare(string x, string y) 
            { 
                // Compare x and y in assending order. 
                // reverse order >> y.CompareTo(x)
                return x.CompareTo(y); 
            }
    }

    class Sort2{
        public static void Mysort2(){
            string[] arr = new string[7] {"A",  
                     "D","z" ,"x", "G", "M","B" };
            CustomCompare gg = new CustomCompare();
            Console.WriteLine("\nAfter Sort: ");
            Array.Sort(arr, gg);

            foreach(string g in arr) 
            { 
                Console.WriteLine(g); 
            }

            Array.Sort(arr, 1, 2, new CustomCompare());

            Console.WriteLine("\nSort the array reversely"+ 
                           " in between index 1 to 4");
            foreach(string g in arr) 
            { 
                Console.WriteLine(g); 
            }
        }
    }
    
