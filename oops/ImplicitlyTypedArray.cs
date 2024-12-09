using System;
using System.Collections;
using System.Collections.Generic;
class ITarray{
    public static void ItypedArr(){
        // figured out at run-time
        var iarray=new [] {1,2,3};
        var iarray2=new []{"shiva","ram"};
        var language = new[, ] { {"C", "Java"}, 
                            {"Python", "C#"} };
        
        var jarray = new[] {
            new[] { 785, 721, 344, 123 },
            new[] { 234, 600 },
            new[] { 34, 545, 808 },
            new[] { 200, 220 }
        };
        foreach(String dd in iarray2){
            Console.Write("{0} ",dd);
        }
        Console.WriteLine();

        object[] obj_Arr=new object[6];
        obj_Arr[0]=3.899; 
        obj_Arr[1] = 3;
        obj_Arr[2] = 'g';
        obj_Arr[3] = "Geeks";
        obj_Arr[4] = null;
        obj_Arr[5] = new object();

        foreach(var item in obj_Arr) 
        { 
            Console.Write("{0} ",item); 
        } 
         Console.WriteLine();

        // Dynamic Array
        List<int> myarray = new List<int>(); 
        myarray.Add(2);
        myarray.Add(10);
        myarray.Add(5);
        myarray.Insert(0,11);
        List<int> val=myarray.Slice(0,myarray.Count-2); // start , len
        Console.WriteLine("{0} is sliced list",val.Count);
        myarray.Remove(2);
        //myarray.RemoveAll(i => i>10); // Removes all the elements that match the conditions
        myarray.RemoveAt(0); // idx
        myarray.RemoveRange(0,1); // start and end
        myarray.AddRange([1,2,3,4,5,8] );
        IEnumerable<int> vv = myarray.Except([1,2,3,4,5]); // returns the difference ele
       
        foreach(int i in vv){
            Console.Write("{0} - ",i);
        } 
        Console.WriteLine();
        myarray.Reverse();
        myarray.Sort();
        Console.WriteLine(myarray); //System.Collections.Generic.List`1[System.Int32]

        foreach(int i in myarray){
            Console.Write("{0} ",i);
        }
        

    }

    //Object and Dynamically Typed Arrays

    
}