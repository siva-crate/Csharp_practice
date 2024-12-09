using System;

namespace mypractice{
    class GreatestOfThree{
        int a,b,c; // instance variables

        //paramter-less constructor
        public GreatestOfThree(){
            this.a=5; //default value
            this.b=6;
            this.c=8;
        }
        
        public GreatestOfThree(params int[] myvar){
            this.a=myvar[0];
            this.b=myvar[1];
            this.c=myvar[2];
        }

        public string findGreatest(){
            if(this.a > this.b && this.a > this.c){    
                    string res=string.Format("A is Greater value {0}",this.a);
                    return res;
            }    
            else if(this.b > this.c){

                    string res=string.Format("B is Greater value {0}",this.b);
                    return res;
            }else{
                    string res=string.Format("C is Greater value {0}",this.c);
                    return res;
            }
        }
    }


    }