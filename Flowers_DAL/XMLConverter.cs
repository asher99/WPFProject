using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml.Linq;

namespace DAL
{
    public static class XMLConverter
    {
        public static XElement toXML(this Flower flower)
        {
            return new XElement("Nanny",);
        }

        public static Flower toFlower(this XElement flowerXml)
        {
            Flower flower = null;

            if (flowerXml == null)
            {
                return flower;
            }

            flower = new Flower
            {
                id = Int32.Parse(flowerXml.Element("id").Value),

            };
            return flower;
    }
}
