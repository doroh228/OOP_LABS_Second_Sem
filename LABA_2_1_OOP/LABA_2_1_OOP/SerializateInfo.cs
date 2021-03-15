using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace LABA_2_1_OOP
{
    public static class SerializateInfo
    {
        public static void Serialize<T>(T obj, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }
        public static T Deserialize<T>(string filename)
        {
            T obj;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                try
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(T));
                    obj = (T)formatter.Deserialize(fs);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return obj;
        }
    }
}
