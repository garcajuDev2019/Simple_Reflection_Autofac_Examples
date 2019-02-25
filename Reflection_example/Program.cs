using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type costumerType = executingAssembly.GetType("Reflection_example.Costumer");
            object costumerInstance = Activator.CreateInstance(costumerType);
            MethodInfo getFullNameMethod = costumerType.GetMethod("GetFullName");

            string[] infoMethod = new string[2];
            infoMethod[0] = "Juan";
            infoMethod[1] = "Garcia";

            string fullName = (string)getFullNameMethod.Invoke(costumerInstance, infoMethod);
            Console.WriteLine("Full name: {0}", fullName);
        }
    }
}
