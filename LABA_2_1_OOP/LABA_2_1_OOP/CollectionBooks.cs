﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LABA_2_1_OOP
{
    [Serializable]
    [XmlRoot(Namespace = "LABA2")]
    [XmlType("BOOKS")]
    public class CollectionBooks
    {
        [XmlArray("Collection"), XmlArrayItem("Item")]
        public List<Book> books = new List<Book>();
    }
}
