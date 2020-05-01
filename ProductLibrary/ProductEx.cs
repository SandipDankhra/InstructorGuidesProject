using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLibrary
{
    class ProductEx
    {
        string name;
        double prince;

        ProductEx(string name,double price)
        {
            this.name = name;
            this.price = price;
        }

        publiic override string Tostring()
        {
            string s = price.ToString();
            return "Product : " + name + "" + s;
        }
    }
}
