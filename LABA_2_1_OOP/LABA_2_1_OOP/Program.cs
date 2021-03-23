using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_2_1_OOP
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Form1 f1;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Singleton
    {
        private static Singleton _instance;

        private static readonly object Locker = new object();

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            if (_instance == null)
            {
                lock (Locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        public static void Design(Form form)
        {
            form.BackColor = Color.Red;
            form.Font = new Font("Times New Roman", 9, FontStyle.Italic);
            form.Size = new Size(1100, 740);
        }
    }

    [Serializable]
    public abstract class Prototype<T>
    {
        // поверхностное копирование
        public virtual T Clone()
        { return (T)MemberwiseClone(); }
        // глубокое копирование
        public virtual T DeepCopy()
        {
            using (var stream = new MemoryStream())
            {
                var context = new StreamingContext(StreamingContextStates.Clone);
                var formatter = new BinaryFormatter { Context = context };
                formatter.Serialize(stream, this);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }

    }

    public abstract class AuthorBuilder
    {
        public Author author { get; private set; }
        public void CreateAuthor()
        {
            author = new Author();
        }

        public abstract void GetSn(string sn);
        public abstract void GetFromCountre(string countre);
        public abstract void GetId(string id);
    }
    public class Author1 : AuthorBuilder
    {
        public override void GetFromCountre(string countre)
        {
            author.FromCountre = countre;
        }

        public override void GetId(string id)
        {
            author.ID = id;
        }

        public override void GetSn(string sn)
        {
            author.SN = sn;
        }
    }

    
}
