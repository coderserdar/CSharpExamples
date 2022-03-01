using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix"; 
            }
            return composite;
        }

        public MyNewObject SayHelloFromWCF(MyNewObject sayhello){
            if (sayhello == null)
            {
                throw new ArgumentNullException("This is Hello World from service!");
            }
            if (sayhello.BoolValue)
            {
                sayhello.Hello += "Suffix";
            }
            return sayhello;
        }
    }
}
