/* 
Password Strength Tool
Written by k0ds
https://github.com/k0ds
*/
using System;

namespace goodpassword {
  class Program {

    static void Main(string[] args) {
      bool hasSpecialChar(string input) {
        string specialChar = @ "\|!#$%&/()=?B;B+@B#B'b,{}.-;'<>_,";
        foreach(var item in specialChar) {
          if (input.Contains(item))
            return true;
          //p.counter++;
        }

        return false;
      }

      bool hasCapitalLetter(string input) {

        string caps = "ABCDEFGHIJKLMNOPQRSTUPWXYZ";
        foreach(var item in caps) {
          if (input.Contains(item))
            return true;

        }
        return false;
      }

      Console.WriteLine("Please type in your password");
      string password = Console.ReadLine();

      int passwordL = password.Length;

      if (passwordL < 8) {
        Console.WriteLine("Your password is not at least 8 characters this makes it weaker");

      } else {
        Console.WriteLine("Your password is at least 8 characters this makes it stronger");
        //p.counter++;
      }

      if (hasCapitalLetter(password) == true) {
        Console.WriteLine("Your password has capital letters, this will make it stronger");
        //p.counter++;
      } else {
        Console.WriteLine("Your password does not contain any capital letters, this will make it weaker");
      }

      if (hasSpecialChar(password) == true) {
        Console.
        WriteLine
          ("Your password has special characters, this makes it very strong");
        //p.counter++;

      } else {
        Console.
        WriteLine
          ("Your password does not contain any special characters, while this is not required it makes it stronger");
      }

      /*if (p.counter > 4)
      {
          Console.WriteLine("your password is strong");
      }
      else
      {
          Console.WriteLine("Your password is not strong");
      }
          
      */

    }
  }
}