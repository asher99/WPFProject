using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Flowers_BE;
using Flower_DS;


namespace Flowers_DAL
{
    class Dal_XML_imp : IDal
    {

        public void add(Flower flower)
        {
            var temp = (from f in Ds_XML.Flowers.Elements()
                        where f.Element("name").Value == flower.name
                        select f).FirstOrDefault();
            if(temp == null)
            {
                Ds_XML.Flowers.Add(flower.toXML());
                Ds_XML.SaveFlowers();
            }  
        }

        public void remove(string flower)
        {
            XElement flowerElement  = (from f in Ds_XML.Flowers.Elements()
                                       where f.Element("name").Value == flower
                                       select f).FirstOrDefault();
            if(flowerElement != null)
            {
                flowerElement.Remove();
                Ds_XML.SaveFlowers();
            }
        }

        public IEnumerable<Flower> display()
        {
            XElement root = Ds_XML.Flowers;
            List<Flower> result = new List<Flower>();
            foreach (var f in root.Elements("Flower"))
            {
                result.Add(f.toFlower());
            }
            return result.AsEnumerable();
        }


    }
}
