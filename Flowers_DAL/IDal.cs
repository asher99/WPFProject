using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowers_BE; 

namespace Flowers_DAL
{
    interface IDal
    {
         void add(Flower flower);
         void remove(string name);
         IEnumerable<Flower> display();
        
    }


}
}
