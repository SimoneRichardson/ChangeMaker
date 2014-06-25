using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {

            ChangeMaker(3.18f);
            ChangeMaker(0.99f);
            ChangeMaker(12.93f);

            Console.ReadKey();
                
        }
                static void ChangeMaker(double amount)//takes amount and doubles its value in coins
                {
                    double x = amount;// a var to be changed as assigned to coins
                    int quarters = 0;// var to hold number of coins set to zero
                    int dimes = 0;//var to hold number of coins set to zero
                    int nickles = 0;//var to hold number of coins set to zero
                    int pennies = 0;//var to hold number of coins set to zero
               
                while (x>0.25f)
                //Loops until there is less than one quarter
                {
                    x = x - 0.25f;//takes .25
                    quarters++;
                }
                while (x>0.10f)
                    //Loops until there is less than one dime
                {
                    x = x - 0.10f;//takes .10
                    dimes++;
                }

                while (x>0.05f)
                //Loops until there is less than one nickle
                {
                    x = x - 0.05f;//takes .05
                    nickles++;
                }
                while (x>0.01f)
                //Loops until nothing left
                {
                x = x - 0.05f;//takes .01
                    pennies++;
                }
           
            // prints
            Console.WriteLine("Amount: $"+amount);
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickles: " +nickles);
            Console.WriteLine("pennies: " + pennies);
        }
    }
}
