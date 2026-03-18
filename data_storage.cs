using System;




namespace data_list_1_for_admin
{
    class Test_0_0_00
    {
      public static void Testing_0_0_00()
        {   
            
            
            //user data or whatever we need to store with the user data
            string username = "gorgamda";
            int main_password = 1146;

            //password can be changed by changing the str here
            string main_password_for_1 = "GAMMA";
            bool access;

            string ask_for_admin = Console.ReadLine();

            if (ask_for_admin == main_password_for_1)
            {
                access = true;
            }
            else
            {
                access = false;
            }
            if (access == true)
            {
                Console.WriteLine(username + " " + main_password); // need to update every time i change the total amount of values 
            }
        }      
    }
}


namespace Main_run // just in case, define everything before calling it, might help with compiling speed
{
    class Absolute_main
    {
        public static void Main()
        {
            data_list_1_for_admin.Test_0_0_00.Testing_0_0_00(); 
        }
    }
}