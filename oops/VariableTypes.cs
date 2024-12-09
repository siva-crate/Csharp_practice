using System;
using System.Security.Cryptography;

namespace oops{
    class Types_Of_Var{

        //instance variable
        String instance_var = "Instance Variable";
        const String const_var="Constant Variable";

        static String static_var = "static variable";

        readonly String readonly_var;
        
        
        // constructor
        public Types_Of_Var(){

                this.readonly_var="ReadOnly Variable";
                Types_Of_Var.static_var="Static Variable"; // intializing in methods
                
               }
        
        public int getAge(){
            //local variable
            int age =0; // if not assigned unsigned error will get
            age = age +10; 
            Console.WriteLine("Local variable of method scope {0}",age);
            {
                // int age; (will get error)
                int myAge=18;
                Console.WriteLine("This is a local variable of having block scope {0}",myAge);
                string local_var="local variable";
                Console.WriteLine("{0} {1} {2} {3} {4} {5}",this.instance_var,const_var,static_var,Types_Of_Var.static_var,local_var,this.readonly_var);
        
                
            }

            //Console.WriteLine(myAge); ( cannot access here)
            return age;
            
        }
    } 
}