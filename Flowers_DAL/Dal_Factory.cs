using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers_DAL
{
    class Dal_Factory
    {
        private static IDal dal;

        private Dal_Factory() { }

         static Dal_Factory() { dal = new DB(); }
       // static Dal_Factory() { dal = new Dal_XML_imp(); }

        public static IDal Get_DAL { get { return dal; } }
    }
}
