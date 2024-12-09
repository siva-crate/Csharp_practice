using System;
using mypractice; // folderName as namespace here

class StartPoint{
    public static void Main(string[] args){
        mypractice.Helloworld helloworld = new mypractice.Helloworld();
        GreatestOfThree findGreat = new GreatestOfThree(); //10,20,30

        try{
                //helloworld.display(); // cant be accessed directly hence it is a static method.
        }catch(Exception obj){
            Console.WriteLine("Error Occured");
        }finally{
            // mypractice.Helloworld.display(); // to access
            // Helloworld.display();
            // string res = findGreat.findGreatest();
            // Console.WriteLine(res);

            // FindPrime obj = new FindPrime();
            // string res= obj.primeNumCheck();
            // Console.WriteLine(res);


            Vardeclarations obj = new Vardeclarations();
            obj.WaysToDefine();

            

        }
        

        
    }
}