using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers_BE
{
   public class Flower
    {
        public string name { set; get; }
        public string description { set; get; }
        public string growingArea { set; get; }
        public Color color { set; get; }
        public Image newImage { set; get; }

        
    }
}
