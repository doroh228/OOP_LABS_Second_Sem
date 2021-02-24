using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LABA_2_OOP
{
    [Serializable]
    [XmlRoot(Namespace = "LABA2")]
    [XmlType("BOOK")]
    public class Book
    {
        #region Properties
        [XmlElement(ElementName = "NameBook")]
        public string Name { get; set; }
        [XmlElement(ElementName = "IDBook")]
        public string Id { get; set; }
        [XmlElement(ElementName = "FromBook")]
        public string From { get; set; }
        [XmlElement(ElementName = "CountreBook")]
        public string Countre { get; set; }
        [XmlElement(ElementName = "GenreBook")]
        public string Genre { get; set; }
        [XmlElement(ElementName = "ReleaseDateBook")]
        public string ReleaseDate { get; set; }
        public string Binding { get; set; }
        public Author author { get; set; }
        #endregion

        public Book(string name, string id, string from, string countre, string genre, string releaseDate, string binding, Author author)
        {
            Name = name;
            Id = id;
            From = from;
            Countre = countre;
            Genre = genre;
            ReleaseDate = releaseDate;
            Binding = binding;
            this.author = author;
        }
        public Book()
        {
        }
    }
}
