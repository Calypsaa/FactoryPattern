using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ClassAFactory : IFactory
    {
        public Class Create()
        {
            Class @class = new ClassA();
            return @class;
        }
    }
}
