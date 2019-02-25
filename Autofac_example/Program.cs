using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Autofac_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var App = new ContainerBuilder();
            App.RegisterType<Costumer>().As<ICostumer>();
            var builder = App.Build();
            var costumer = builder.Resolve<ICostumer>();
            Console.WriteLine(costumer.GetFullName("Juan", "Garcia"));
            Console.ReadKey();
        }
    }
}
