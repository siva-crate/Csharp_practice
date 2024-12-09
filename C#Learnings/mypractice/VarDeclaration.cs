using System;

namespace mypractice{
    class Vardeclarations{
        int default_num =22; // direct value
        int type_caste = (int) 25.5; // one type to another type value (explict type conversion)

        static short default_short=12; // static variable
        int type_conv = default_short; // short to (type casting)

        
        int user_value=Convert.ToInt32(Console.ReadLine());

        // other types (built-in types)
        short short_type = 22;
        sbyte byte_type = 10;

        long long_type = 200l;

        decimal decimal_type = 1200;

        float float_type = 12.25f;

        double double_type = 22.24d;

        string string_type = "my string";

        char char_type = 'c';

        bool bool_type = true;

        string null_type=null; // reference type can have null

        object null_object=null;

        // dynamic types

        dynamic my_dym ="shiva";
        

        public  void WaysToDefine()
        {
            var my_var = "allowed only in method area";
            Console.WriteLine("{0} is default_num type is {1}",my_var, my_var.GetType());
            Console.WriteLine("{0} is default_num type is {1}",this.my_dym, this.my_dym.GetType());
            this.my_dym = 2;
            Console.WriteLine("{0} is default_num type is {1}",this.my_dym, this.my_dym.GetType());
            Console.WriteLine("{0} is default_num type is {1}",this.default_num, this.type_conv.GetType());
            Console.WriteLine("{0} is type_caste type is {1}",this.type_caste, this.type_conv.GetType());
            Console.WriteLine("{0} is user_value type is {1}",this.user_value, this.type_conv.GetType());
            Console.WriteLine("{0} is type_conv type is {1}",this.type_conv, this.type_conv.GetType());
        }


    }
}