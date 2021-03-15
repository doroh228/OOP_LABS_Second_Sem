using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        [StringLength(50, MinimumLength = 1)]
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
    public class UserNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string userName = value.ToString();
                if (!userName.StartsWith("T"))
                    return true;
                else
                    this.ErrorMessage = "Имя не должно начинаться с буквы T";
            }
            return false;
        }
    }
}
