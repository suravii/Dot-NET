using System;

namespace NCCLabSuravi33
{
    public partial class User
    {
        private string name;
        private string location;
        public User(string a, string b)
        {
            this.name = a;
            this.location = b;
        }
    }
    public partial class User
    {
        public void GetUserDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Location: " + location);
        }
    }

    internal class PartialClass
    {
        static void Main(string[] args)
        {
            User u = new User("Suravi Shrestha", "Patan");
            u.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine(); // the program will pause and wait for the user to input a line of text.
            Console.WriteLine("\nLab No.: 8(c)\tName: Suravi Shrestha\tRoll No: 33/26472");
        }
    }
}