using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ClassBFactory : IFactory
    {
        public Class Create()
        {
            Class @class = new ClassB();
            return @class;
        }

    }
}
