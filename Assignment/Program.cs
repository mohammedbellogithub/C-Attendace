using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EnterName ename = new EnterName();
            ename.ev_BannedUser += Alarm;
            ename.Name();
            Console.Read();
        }

        static void Alarm(object sender, BannedUserEventArgs e)
        {
            Console.WriteLine("{0} Users Found. Sending Email to Administration.", e.Name);
            Console.WriteLine("Email Sent.");
            Console.WriteLine("Warning Alarm Started.");
        }
    }
}
