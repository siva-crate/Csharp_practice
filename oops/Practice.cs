using System;


namespace oops{
class MyLearnings{

    // single line comments

    public void InputOutPut(){

        string ip1 = Console.ReadLine(); //returns string
        int ip2 = Console.Read(); // returns int value of char

        int ip3 = Convert.ToInt32("2");
        long ip4 = Convert.ToInt64("2");
        short ip5 = Convert.ToInt16("4");
        string ip6 = Convert.ToString(2);
        bool ip7 = Convert.ToBoolean("true");
        char ip8 = Convert.ToChar("a");
        float ip9 =(float) Convert.ToDouble("22.5");
        double ip10 = Convert.ToDouble("22.5");

        Console.WriteLine(" Single line o/p and at end pointer shifts to new line");
        Console.Write("pointer on same line ");
    }

    public void Operators(){

        // Arthimetic 
        int a, b;
        a=10;
        b=20;
        int add_ab = a+b;
        int sub_ab=a-b;
        int mul_ab=a*b;
        int div_ab=a/b;
        Console.WriteLine("{0} \n{1} \n{2} \n{3} \n",add_ab,sub_ab,mul_ab,div_ab);

        //Relational
        if(a>b){
            Console.WriteLine("{0} is bigger",a); // note cannot give {} , only indexed {1} allowed.
        }else if (b>a){
            Console.WriteLine("{0} is bigger",a);
        }else{
             Console.WriteLine("{0} is equal to {1}",a,b);
        }

        //
    }

    public void DataTypes(){

        Console.Write("Enter a Number: ");

        //int customvalue=22.5; will raise error

        int customInt=22;
        int myint = Convert.ToInt32(Console.ReadLine()); // takes only real part , if 22.5 error occurs
        
        long customLong = 22l;
        long mylong = Convert.ToInt64(Console.ReadLine()); // l is not considering

        Console.Write("Enter a Boolean: ");
        bool mybool = Convert.ToBoolean(Console.ReadLine()); // takes only true or false
        bool mybool2=false; //true

        char myChar='c';

        string myString =Console.ReadLine();
        string customString ="this is a string keyword";
        String myStringClass="This is a String Class";

        float myFloat =22.5f;
        double myDouble = 25.5d;

        // Console.WriteLine();
        Console.WriteLine("user entered num is {0} and long {1}",myint,mylong);
        Console.WriteLine("User entered Boolean Data is {0}",mybool); //True
        Console.WriteLine("custom Boolean Data is {0}",mybool2); //False
    }
    public void MyPractice(){
        int x =20;
        int y = 30;
        Console.WriteLine("{0} + {1} = {2}",x,y,x+y);
    }
    public int Mynum(){
        return 2;
    }
}
}