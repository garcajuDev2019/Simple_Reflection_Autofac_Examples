using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac_example
{
    public class Costumer : ICostumer
    {
        public string GetFullName(string firstName, string lastName) => "Full name: " + firstName + " " + lastName;
    }
}
