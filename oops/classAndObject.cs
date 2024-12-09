using System;

class MyClass{

    public MyClass(String fieldval){
        this.MyField="default value";
        this.MyField=fieldval;
    }
    String MyField;
        public int MyMethod(int myparam){
        return 0;
    }
    class NestedClass{
        public void nestedMeth(){

        }
    }
    NestedClass cls = new NestedClass();
}

// can create a obj on MyClass cll = new MyClass();
// cll.attribute or cll.method()

// Default Constructor: A class always has a default constructor that is called when an object of the class is created. A structure, on the other hand, does not have a default constructor by default. However, you can define a default constructor in a structure if you need one
//  Structures are usually smaller in size than classes

// A structure is a collection of variables of different data types under a single unit