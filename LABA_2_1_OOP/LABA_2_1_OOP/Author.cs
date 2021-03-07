using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2_1_OOP
{
    public class Author
    {
        public Author(string sN, string fromCountre, string iD)
        {
            SN = sN;
            FromCountre = fromCountre;
            ID = iD;
        }
        public Author() { }
        #region Properties
        public string SN { get; set; }

        public string FromCountre { get; set; }

        public string ID { get; set; }
        #endregion
    }
}
