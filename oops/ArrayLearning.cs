using System;

namespace oops{
    class MyArray{
        int[] arr= new int[5]{11,12,13,14,15};
        public int[] arrayInit(){
            for(int i=0;i<arr.Length;i++){
                Console.Write(" Enter a num for idx {0} is ",i);
                arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        return arr;
        }

        public bool getArray(){
            Console.WriteLine("Array is {0}",arr);

            foreach(int i in arr){
                Console.Write("{0} ",i);
            }
            return true;
        }

        public void ArrMethods(){
            Console.WriteLine(arr.All(ele => ele >10)); // Returns True or False (if all satiesfied)
            Console.WriteLine(arr.Any(ele=> ele >=15)); // Returns True or False (if any satiesfied)
            int idx=arr.Length;
            // A new sequence that ends with element
            Console.WriteLine("{0}",arr.Append(20)); // System.Linq.Enumerable+AppendPrepend1Iterator`1[System.Int32]
            IEnumerable<int> a=arr.Append(20);
            foreach(int i in  a){
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
            Console.WriteLine(arr.Average()); // returns a double
            object cloned_arr=arr.Clone(); // creates a shallow copy
            Console.WriteLine(arr.ToString()); // System.Int32[]
            Console.WriteLine(arr.Count()); //len of elements (consider 0-5)
            Console.WriteLine(arr.Contains(16)); //True or False
            Console.WriteLine(arr.Concat([1,2,3,4,5]));
            IEnumerable<int> concated_arr=arr.Concat([1,2,3,4,5]);

            foreach(int i in concated_arr){
                Console.Write("{0} ",i);
            }
            int[] dbl = {1,2,3,1,2,4,5};
            IEnumerable<int> dbl2=dbl.Distinct(); //unique elements
            Console.WriteLine();
            foreach(int i in dbl2){
                 Console.Write("{0} ",i);
            }
            Console.WriteLine(arr.ElementAt(0));
            Console.WriteLine(arr.Equals(11)); //True or False
            Console.WriteLine(arr.First()); // returns first element
            Console.WriteLine(arr.GetType); //System.Func`1[System.Type]
            Console.WriteLine(arr.GetLength); //System.Func`2[System.Int32,System.Int32]
            Console.WriteLine(arr.IsFixedSize); //True
            Console.WriteLine(arr.IsReadOnly); //False
            Console.WriteLine(arr.Last()); //Returns the last element
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Reverse());
            
           foreach(int i in arr.OrderByDescending( ele => ele>13) ) {
                Console.Write("{0} ", i);
           }
            
        }
        
    }
}