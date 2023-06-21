using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staj_proje1
{
    internal class main
    {
        static void Main(string[] args)
        {

            UserOperations userOperations = new UserOperations();

            userOperations.login();

            userOperations.PasswordCheck();

        }
    }
}
