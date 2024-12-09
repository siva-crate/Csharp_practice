using System;

namespace mypractice{
    class FindPrime{
        public FindPrime(){

        }
        public string primeNumCheck(){
        //    string res ="";
            

            do{
                Console.WriteLine("welcome to primeNumber Check");
                Console.WriteLine("1. checks a Number whether it's prime or not ");
                Console.WriteLine("2. checks a range of numbers whether it's prime or not ");
                Console.Write("choose an Option : ");
                int ip = Convert.ToInt32(Console.ReadLine());

                switch (ip){
                    case 1:
                        Console.Write("Enter a Number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        int flag=0;
                        for(int i=2;i<num;i++){
                            if (num % i ==0){
                                string res =string.Format("{0} is not a Prime Number ",num);
                                flag =1;
                                return res;
                            }

                        }
                        if(flag ==0){
                        string res =string.Format("{0} is a Prime Number",num);
                        return res;
                        }
                        break; 

                    case 2:

                    Console.Write("Enter a Number : ");
                    num = Convert.ToInt32(Console.ReadLine());

                    while(num>1){

                            if(num==2){
                                return string.Format("{0} is a prime",num);
                            }

                            flag=0;
                            for(int i=2;i<num;i++){

                                if (num % i ==0){
                                    string res =string.Format("{0} is not a Prime Number ",num);
                                    Console.Write(res+" ");
                                    flag=1;
                                    break;
                                }

                            }

                            if (flag !=1){
                                Console.Write(string.Format("{0} is a Prime Number ",num));
                            }
                            num--;
                            
                        }
                        return "Not a Prime Number";
                            
                        break;
                }
            }while(false);
            return "";
        }
    }
}