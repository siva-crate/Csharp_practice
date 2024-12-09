// Implicitly Typed Local Varibales
// without specifiying the .NET type explictly.
// automaticaly detected by value at compile tym. (scope of the implicitly typed variable is local.) 
// declared using var and allowed in local only. && must intialize the variables. and not accept null.
// not allowed multiple var in a single statements. eg: var a = 20 , b =30;
// It is not allowed to use var as a field type in class level.
// var data = new int [] {23, 34, 455, 65};
// Note: Implicitly typed local variables can be used as a local variable in a function, in foreach, and for loop, as an anonymous type, in LINQ query expression, in using statement etc.


using System;

namespace oops{
    class TypeCasting_exp{

        
        public TypeCasting_exp(){
            var imp = "Implicitly Typed Local Variable";
            Console.WriteLine(imp);
        }

        public void myExample(){
            var a = 50;
            var b = "Welcome! Geeks";
            var c = 340.67d;
            var d = false;

            Console.WriteLine("Type of 'a' is : {0} ", a.GetType());
        }

    }
}