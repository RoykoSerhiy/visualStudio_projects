using System;
using System.Collections;

class Laptop
{
    public string Vendor { get; set; }
    public double Price { get; set; }

    public Laptop(string v, double p)
    {
        Vendor = v;
        Price = p;
    }

    public override string ToString()
    {
        return Vendor + " " + Price;
    }
}

class Shop : IEnumerable
{
    Laptop[] laptopArr;

    public Shop(int size)
    {
        laptopArr = new Laptop[size];
    }

    public int Length
    {
        get { return laptopArr.Length; }
    }

    public Laptop this[int pos]
    {
        get
        {
            if (pos < 0 || pos >= laptopArr.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return (Laptop)laptopArr[pos];
            }
        }
        set
        {
            if (pos < 0 || pos >= laptopArr.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                laptopArr[pos] = (Laptop)value;
            }
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return laptopArr.GetEnumerator();
    }

    private int FindByVendor(string vendor)
    {
        for (int i = 0; i < laptopArr.Length; i++)
        {
            if (laptopArr[i].Vendor == vendor)
            {
                return i;
            }
        }
        return -1;
    }

    private int FindByPrice(double price)
    {
        for (int i = 0; i < laptopArr.Length; ++i)
        {
            if (laptopArr[i].Price == price)
            {
                return i;
            }
        }
        return -1;
    }

    public Laptop this[double price]
    {
        get
        {
            if (price < 0)
            {
                throw new Exception("Wrong price");
            }

            return this[FindByPrice(price)];
        }
    }
    public Laptop this[string vendor]
    {
        get
        {
            if (vendor.Length == 0)
            {
                throw new Exception("Wrong vendor name");
            }

            return this[FindByVendor(vendor)];
        }
    }
}

class Indexer
{
    static void Main()
    {
        Shop shop = new Shop(3);
        shop[0] = new Laptop("Asus", 4900);
        shop[1] = new Laptop("Acer", 3300);
        shop[2] = new Laptop("Dell", 2900);

        try
        {
            //for (int i = 0; i < shop.Length; i++)
            //{
            //    Console.WriteLine(shop[i].ToString());
            //}
            foreach (Laptop lt in shop)
            {
                Console.WriteLine(lt.ToString());
            }

            Console.WriteLine("===================");
            //Console.WriteLine(shop["Asus"]);
            //double p = 4900;
            Console.WriteLine(shop[(double)4900]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}