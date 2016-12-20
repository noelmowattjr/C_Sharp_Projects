using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_101
{
    //--Interface--//
    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedsSave { get; set; }
    }

    //--Interface for Encrypt
    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();
    }

    class Document : IStorable, IEncryptable
    {
        private string name;
        private Boolean mNeedsSave = false;

        //--Constructor
        public Document(string s)
        {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        //--Save and Load Methods
        public void Save()
        {
            Console.WriteLine("Saving the Document");
        }

        public void Load()
        {
            Console.WriteLine("Loading the Document");
        }

        //----Getter and Setter for NeedsSave
        public Boolean NeedsSave
        {
            get { return mNeedsSave; }
            set { mNeedsSave = value; }
        }

        //-----Encrypt Methods-------------//
        public void Encrypt()
        {
            Console.WriteLine("Encrypting the document");
        }

        public void Decrypt()
        {
            Console.WriteLine("Decrypting the document");
        }
    }
}
