using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace coolExamples
{
    [Serializable]
    class Product
    {
        public long _id;
        public string _title;
        public double _price;
        [NonSerialized]
        public string _notes;

        public Product(long id, string title, double price, string notes)
        {
            _id = id;
            _title = title;
            _price = price;
            _notes = notes;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1} (${2:F2}) {3}", _id , _title , _price , _notes);
        }

    }


    class Program
    {
        static void Main()
        {
            List<Product> prod = new List<Product>();

            prod.Add(new Product(1, "Laptop Acer", 3500, "good stuff"));
            prod.Add(new Product(2, "Laptop Asus", 3600, "made in China"));
            prod.Add(new Product(3, "Laptop Dell", 3700, "one for the kind"));

            IFormatter serializer = new BinaryFormatter();
            FileStream saveFile =
                new FileStream("Products.bin" , FileMode.Create , FileAccess.Write);

            serializer.Serialize(saveFile, prod);
            saveFile.Close();





            FileStream loadFile =
                new FileStream("Products.bin", FileMode.Open, FileAccess.Read);

            List<Product> savedProds =
                serializer.Deserialize(loadFile) as List<Product>;
            loadFile.Close();

            foreach (Product p in savedProds)
            {
                Console.WriteLine(p);
            }

        }
    }
}
