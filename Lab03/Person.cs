using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Person
    {
        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }

        public static string GetStaticName()
        {
            return Name;
        }
    }
}
