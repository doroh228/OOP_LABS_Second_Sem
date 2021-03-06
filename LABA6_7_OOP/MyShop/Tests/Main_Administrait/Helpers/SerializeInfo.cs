﻿using System;
using System.IO;
using System.Xml.Serialization;

namespace Main_Administrait.Helpers
{
    class SerializeInfo
    {
        public static void Serialize<T>(T obj, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fs, obj);
            }
        }
        public static T Deserialize<T>(string filename)
        {
            T obj;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                    XmlSerializer formatter = new XmlSerializer(typeof(T));
                    obj = (T)formatter.Deserialize(fs);
            }
            return obj;
        }
    }
}
