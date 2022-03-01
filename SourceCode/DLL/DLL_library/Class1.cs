using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_library
{
    public class ClassFromDLL
    {
        public string ExampleMethod(string type_something)
        {
            return "Hello from DLL_library, you typed: " + type_something;
        }
    }
}
