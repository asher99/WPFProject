using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Flowers_BE;
using System.Xml.Linq;

namespace Flowers_DAL
{
    public static class XMLConverter
    {
        public static XElement toXML(this Flower flower)
        {            
            return new XElement("Flower",
                new XElement("name", flower.name),
                new XElement("description", flower.description),
                new XElement("growingArea", flower.growingArea),
                new XElement("color", flower.color.Name),
                new XElement("newImage", flower.newImage.ToString())
              );
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
                name = flowerXml.Element("name").Value,
                description = flowerXml.Element("description").Value,
                growingArea = flowerXml.Element("growingArea").Value,
                color = Color.FromName(flowerXml.Element("color").Value),
                newImage = Image.FromFile(flowerXml.Element("newImage").Value) 
            };
                
            return flower;
        }
    }
}
