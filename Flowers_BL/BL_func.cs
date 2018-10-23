using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowers_DAL;
using Flowers_BE;

namespace Flowers_BL
{
    public class BL_func
    {
        DB mydb;

        public BL_func()
        {
            mydb = new DB();
        }

        public void add(Flower flower)
        {
            mydb.add(flower);
        }

        public void remove(string name)
        {
            mydb.remove(name);
        }

        public List<Flower> sub_list(string subname)
        {
            List<Flower> listOfSubname = new List<Flower>();
            foreach (Flower item in mydb.display())
            {
                if (item.name.Contains(subname))
                {
                    listOfSubname.Add(item);
                }
            }
            return listOfSubname;
        }
    }
}
