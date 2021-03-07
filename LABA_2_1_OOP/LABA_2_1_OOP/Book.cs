using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LABA_2_1_OOP
{
    [Serializable]
    [XmlRoot(Namespace = "LABA2")]
    [XmlType("BOOK")]
    public class Book
    {
        public Book(string name, string uDK, string publishing, int sizeFile,
                    int countPages, string format, string releaseDate, ContenerAuthors authors)
        {
            Name = name;
            UDK = uDK;
            Publishing = publishing;
            SizeFile = sizeFile;
            CountPages = countPages;
            Format = format;
            ReleaseDate = releaseDate;
            Authors = authors;
        }

        public Book() { }

        #region Properties
        [XmlElement(ElementName = "NameBook")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Format")]
        public string Format { get; set; }

        [XmlElement(ElementName = "UDKBook")]
        public string UDK { get; set; }

        [XmlElement(ElementName = "Publishing")]
        public string Publishing { get; set; }

        [XmlElement(ElementName = "SizeFile")]
        public int SizeFile { get; set; }

        [XmlElement(ElementName = "CountPages")]
        public int CountPages { get; set; }

        [XmlElement(ElementName = "ReleaseDateBook")]
        public string ReleaseDate { get; set; }

        [XmlElement(ElementName = "Authors")]
        public ContenerAuthors Authors { get; set; }
        #endregion

    }
}
