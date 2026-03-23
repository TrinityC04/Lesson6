using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User2
    {
        private string _username;

        public User2(string username)
        {
            _username = username;
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Username cannot be empty.");
                    return;
                }

                _username = value;
            }
        }
    }
}
