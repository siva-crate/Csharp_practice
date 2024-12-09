using System;
class MultiArr{
    public static void myDim(){
        int[,] intarray = new int[,]{
            {1,2},{3,4},{5,6},{7,8}
        };

        int[, ] intarray_d = new int[4, 2] {{ 1, 2},  
                                             {3, 4},  
                                             {5, 6}, 
                                             {7, 8}};
    int[,, ] intarray3D = new int[,, ] {{{ 1, 2, 3}, 
                                            { 4, 5, 6}}, 
                                            {{ 7, 8, 9}, 
                                         {10, 11, 12}}};
        // Array.GetLongLength(Int32) Method
    Console.WriteLine(intarray.GetLongLength(1)); // 0 >> 4 size , 1 >> 2 elements in each
    
    Console.WriteLine(intarray.GetLongLength(1).GetType()); // System.int64

    Console.WriteLine(intarray.Equals(intarray)); // shallow copy obj returns true

    // total number of elements in all the dimensions

    Console.WriteLine("{0} is total elements length",intarray.LongLength); // Total elements
    
    Console.Write("Total Number of Elements in intarray: "); 
  
        // using Length property 
        Console.Write(intarray.Length); 

        // Rank is used to tell the no of dimensions.
        Console.Write("\n{0} represents no of dimensions",intarray.Rank);



  
        Console.Write("\nTotal Number of Elements in intarray_d: "); 
  
        // using Length property 
        Console.Write(intarray_d.Length); 
  
        Console.Write("\nTotal Number of Elements in intarray3D: "); 
  
        // using Length property 
        Console.Write(intarray3D.Length); 
  
        Console.Write("\nTotal Number of Elements in intarray3Dd: "); 
  
        // using Length property 
        
        
    }

     
}