using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Flower_DAL;
namespace Flower_DS
{
    public static class Ds_XML
    {       
            // determine a directory for the XML files of this solutions
            private static string solutionDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName;

            // determine a path for the XML files
            private static string filePath = System.IO.Path.Combine(solutionDirectory, "Flower_DS", "Ds_XML");

            // define path for the XML files:
           
            private static XElement flowerRoot = null;
            static string flowerPath = Path.Combine(filePath, "FlowerXML.xml");

            /// Static Constructor
            static Ds_XML()
            {
                // check if default directory exist, if not - create it. 
                bool exists = Directory.Exists(filePath);

                if (!exists)
                {
                    Directory.CreateDirectory(filePath);
                }

                // if needed files aren't exist - create them. anyway, load the data from those directories / files.
                if (!File.Exists(flowerPath))
                {
                    CreateFile("Flowers", flowerPath);

                }                                      
            }


            /// <summary>
            /// save the Xelement to the root.
            /// </summary>
            /// <param name="root"></param>
            /// <param name="path"></param>
            public static void Save(XElement root, string path)
            {
                root.Save(path);
            }
          
            public static void SaveFlowers()
            {
                flowerRoot.Save(flowerPath);
            }
          
            public static XElement Flowers
            {
                get
                {
                    flowerRoot = LoadData(flowerPath);
                    return flowerRoot;
                }
            }
                
            /// Create XML file.
            private static void CreateFile(string typename, string path)
            {
                XElement root = new XElement(typename);
                root.Save(path);
            }

            /// load the XML file.
            private static XElement LoadData(string path)
            {
                XElement root;
                try
                {
                    root = XElement.Load(path);
                }
                catch
                {
                    throw new Exception("File upload problem");
                }
                return root;
            }
        }
    }

