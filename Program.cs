using System;
using System.Collections.Generic;

namespace Week2_HW1
{
    class Tshirt
    {
        public int id;
        public string size;
        public string color;
        public float price;
        public string image;

        public Tshirt(int valueid, string valuesize, string valuecolor, float valueprice, string valueimage)
        {
            id = valueid;
            size = valuesize;
            color = valuecolor;
            price = valueprice;
            image = valueimage;

        }
    }
    class User
    {
        public string name;
        public string email;
        public string order;
        public string address;
        public float totalcost;
        public User(string valuename, string valueemail, string valueorder, string valueaddress, float valuetotalcost)
        {
            name = valuename;
            email = valueemail;
            order = valueorder;//ข้อมูลใน Shoppingcart
            address = valueaddress;//ข้อมูลใน Shoppingcart
            totalcost = valuetotalcost;//ข้อมูลใน Shoppingcart

        }
    }

    class Shoppingcart
    {
        public List<Tshirt> orderTshirt;
        public List<Address> address;
        public float totalcost = 0f;
        public Shoppingcart(float valuetotalcost)
        {
            orderTshirt = new List<Tshirt>();
            address = new List<Address>();
            totalcost = valuetotalcost;
        }
        public string addList(Tshirt order, string valueorder)
        {
            orderTshirt.Add(order);//เก็บlistของออเดอร์ลูกค้า
            string keeporder = valueorder;
            foreach (Tshirt orders in orderTshirt) //ทำเป็นข้อความเพื่อให้สามารถส่งไปที่mainและuserได้
            {
                keeporder = "";
                keeporder += order.id;
                keeporder += ". ";
                keeporder += order.size;
                keeporder += " ";
                keeporder += order.price;
                keeporder += " ";
                keeporder += order.image;
                keeporder += "\n";
            }

            return (keeporder);
        }
        public string addListaddress(Address useraddress, string valueaddress)
        {
            address.Add(useraddress);
            string keepaddress = "";
            foreach (Address addresses in address)//ทำเป็นข้อความเพื่อให้สามารถส่งไปที่mainและuserได้
            {
                keepaddress += useraddress.street;
                keepaddress += useraddress.city;
                keepaddress += useraddress.zipcode;
            }
            valueaddress = keepaddress;
            return (valueaddress);
        }
    }

    class Address
    {
        public int id;
        public string street;
        public string city;
        public string zipcode;

        public Address(int valueid, string valuestreet, string valuecity, string valuezipcode)
        {
            id = valueid;
            street = valuestreet;
            city = valuecity;
            zipcode = valuezipcode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address(1, "131/75, Puttamonton street ", "Nakornpratom ", "10180");
            Tshirt order1 = new Tshirt(1, "L", "Red", 500f, "RedShirt");
            Tshirt order2 = new Tshirt(2, "M", "Black", 750f, "BlackShirt");
            Tshirt order3 = new Tshirt(3, "S", "Purple", 625f, "PurpleShirt");
            float totalcost = order1.price + order2.price + order3.price;
            Shoppingcart orderTshirt = new Shoppingcart(totalcost);
            string keepaddress = "";
            string keeporder = "";
            float totalprice = orderTshirt.totalcost;

            keeporder += orderTshirt.addList(order1, keeporder);//รับข้อมูลข้อความของorder1จากเมธอด
            keeporder += orderTshirt.addList(order2, keeporder);//รับข้อมูลข้อความของorder2จากเมธอด
            keeporder += orderTshirt.addList(order3, keeporder);//รับข้อมูลข้อความของorder3จากเมธอด
            keepaddress = orderTshirt.addListaddress(address, keepaddress);//รับข้อมูลข้อความของที่อยู่จากเมธอด


            User jame = new User("jame watson", "jame@gmail.com", keeporder, keepaddress, totalprice);//ส่งข้อมูลinstantไปที่user
            Console.WriteLine("===================\n ORDER \n===================");
            Console.WriteLine(jame.order);
            Console.WriteLine("=======================\n CUSTOMER INFORMATION \n=======================");
            Console.WriteLine("NAME: {0}", jame.name);
            Console.WriteLine("E-MAIL: {0}", jame.email);
            Console.WriteLine("ADDRESS: {0}", jame.address);
            Console.WriteLine("Total-Cost: {0} BAHT", jame.totalcost);

            Console.WriteLine();
        }
    }
}

