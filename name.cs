using System;

namespace name
{
  class Program
  {
    static void Main(sttring[]args)
    {
      //string the first name and the last name as fname and lname
      //Ask the user to input their first name
      //Save the entered input 
      string fname, lname;
      Console.WriteLine("Tell me your first name: ");
      fname = console.ReadLine();

      //Repeat the same process but this time ask for their last name
      //Save the entered input
      //You do not have to use the string command for the lname as it has already been done
      Console.WriteLine("Tell me your last name: ");
      lname = Console.ReadLine();

      //Add both names together and then print out the result
      Console.WriteLine("Your Fullname is " + fname + " " + lname );
      
    }
  }
}
