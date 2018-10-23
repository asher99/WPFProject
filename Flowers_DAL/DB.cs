﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowers_BE;

namespace Flowers_DAL
{
    public class DB
    {
        List<Flower> dbList;
        public DB()
        {
            dbList = new List<Flower>();
        }

        public void add(Flower flower)
        {
            dbList.Add(flower);
        }

        public void remove(string name)
        {
            foreach (Flower item in dbList)
            {
                if (item.name==name)
                {
                    dbList.Remove(item);
                }
            }
        }

        public List<Flower> display()
        {
            return dbList;
        }
    }
}