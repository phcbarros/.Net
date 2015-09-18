﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQSuccinctly.Capitulo1
{
    public static class LocalAndIntepretedQueries
    {
        public static void LerXML()
        {

            var xml = @"
                <ingredients>
                    <ingredient name='milk' quantity='200' price='2.99' />
                    <ingredient name='sugar' quantity='100' price='4.99' />
                    <ingredient name='safron' quantity='1' price='46.77' />
                </ingredients>";

            XElement xmlData = XElement.Parse(xml);

            XElement milk = xmlData.Descendants("ingredient")
                                        .First(x => x.Attribute("name").Value == "milk");
            XAttribute nameAttribute = milk.FirstAttribute; // name attribute
            XAttribute priceAttribute = milk.Attribute("price");

            string priceOfMilk = priceAttribute.Value; // 2.99

            XAttribute quantity = milk.Attributes()
                                        .Skip(1)
                                        .First(); // quantity attribute

            Console.WriteLine("Name: {0}", nameAttribute);
            Console.WriteLine("Price: {0}", priceOfMilk);
            Console.WriteLine("Quantity: {0}", quantity.Value);
        }
    }
}

