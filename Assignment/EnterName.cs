using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class EnterName
    {

        public event EventHandler<BannedUserEventArgs> ev_BannedUser;
        public void Name()
        {
            Console.Write("Enter You Name : ");
            string name = Console.ReadLine();

            if ((name == "Jack" || name == "Steven" || name == "Mathew") && (ev_BannedUser != null))
            {
                ev_BannedUser(this, new BannedUserEventArgs(name));
            }
            else
            {
                Console.WriteLine("Welcome to " + name);
            }
        }

    }
}
