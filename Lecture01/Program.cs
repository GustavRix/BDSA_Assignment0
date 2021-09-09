using System;
using System.IO;
using System.Text; 

namespace Lecture01
{
     public class Program
    {
        public static void Main(string[] args)
        {    
            bool check = false;
            Console.WriteLine("Enter leap year you wish to check:");
            string leap = Console.ReadLine();

            int number;
            //bool success = int.TryParse(leap, out number);
            if(!int.TryParse(leap, out number))
            {
             System.Console.WriteLine("Your current input is not valid.");
             
            }else{

             if(Calculator.IsLeapYear(number)==true){
                            System.Console.WriteLine("yay");
                            check = true;
                        }else {
                            check = true;
                            System.Console.WriteLine("nay");
                        }
            }
      

               //System.Console.WriteLine(check);
            if(args == null && check == false || args.Length == 0 && check == false){
                System.Console.WriteLine("You have two options one you can type leap and then a year like so 'leap 2020' and it will tell you if its a leap year. Or you can type a number then powerof and a number like so '25 powerof 5' and it will tell you if the number is a powered version of the power.");
            }     
        }
    }
}
