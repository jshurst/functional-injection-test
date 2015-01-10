using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalInjection.Web
{
    public class DataRepo
    {
        public static string GetPerson(string personId)
        {
            return "Found person " + personId;
        }

        public static string GetAddress(string personId)
        {
            return "Found city for person " + personId;
        }
    }
}
