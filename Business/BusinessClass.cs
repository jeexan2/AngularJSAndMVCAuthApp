using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class BusinessClass : IBusiness
    {
        IData dataClass;
        public BusinessClass(IData _dataClass)
        {
            dataClass = _dataClass;
        }
        public string BusinessData()
        {
            return dataClass.GetData();
        }
    }
}
