using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataClass : IData
    {
        public string GetData()
        {
            return "Data Model";
        }
    }
}
