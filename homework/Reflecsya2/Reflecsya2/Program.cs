﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflecsya2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Id = 1,
                Login = "zhaxylykov_ob",
                Password = "9801"
            };

            Type type = typeof(User);

            Console.WriteLine("Type is: {0}", type.Name);
            PropertyInfo[] props = type.GetProperties();

            Console.WriteLine("Properties (N = {0}):",
                              props.Length);

            foreach (var prop in props)
                if (prop.GetIndexParameters().Length == 0)
                    Console.WriteLine("   {0} ({1}): {2}", prop.Name,
                                      prop.PropertyType.Name,
                                      prop.GetValue(user, null));

            Console.ReadLine();
        }
    }
}
