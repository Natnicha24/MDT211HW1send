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

        public User(string valuename, string valueemail)
        {
            name = valuename;
            email = valueemail;
        }
    }

  class Shoppingcart
    {
        public List<Tshirt> orderTshirt;
        public List<Address> address;
        public float totalcost=0f;
        public Shoppingcart(float valuetotalcost)
        {
            orderTshirt = new List<Tshirt>();
            address = new List<Address>();
            totalcost = valuetotalcost;
        }
        public void addList(Tshirt order)
        {
            orderTshirt.Add(order);
        }
        public void addListaddress(Address useraddress)
        {
            address.Add(useraddress);
        }
        public void showorder()//Methodของการนำออเดอร์มาแสดง
        {
            Console.WriteLine("===================\n ORDER \n===================");
            foreach (Tshirt order in orderTshirt)
            {
                Console.Write("{0}.",order.id);
                Console.WriteLine(" size: {0}", order.size);
                Console.WriteLine("   color: {0}", order.color);
                Console.WriteLine("   price: {0}", order.price);
                Console.WriteLine("   image:{0}\n", order.image);
            }
           
        }
        public void showinformation()//Methodของการนำข้อมูลลูกค้ามาแสดง
        {
            foreach (Address useraddress in address)
            {
                Console.Write("ADDRESS: {0}",useraddress.street);
                Console.Write(" {0}",useraddress.city);
                Console.WriteLine(" {0}",useraddress.zipcode);
            }   
                Console.WriteLine("\nTotal-Cost: {0} BAHT", totalcost);
        }
        }
   

    class Address
    {
        public int id;
        public string street;
        public string city;
        public string zipcode;

        public Address(int valueid,string valuestreet,string valuecity,string valuezipcode)
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
                    User jame = new User("jame watson", "jame@gmail.com");
                    Address address=new Address(1,"131/75, Puttamonton street", "Nakornpratom", "10180");
                    Tshirt order1 = new Tshirt(1, "L", "Red", 500f, "RedShirt");
                    Tshirt order2 = new Tshirt(2, "M", "Black", 750f, "BlackShirt");
                    Tshirt order3 = new Tshirt(3, "S", "Purple", 625f, "PurpleShirt");
                    float totalcost = order1.price + order2.price + order3.price;
                    Shoppingcart orderTshirt = new Shoppingcart(totalcost);

            orderTshirt.addList(order1);
            orderTshirt.addList(order2);
            orderTshirt.addList(order3);
            orderTshirt.addListaddress(address);
           
            orderTshirt.showorder();

            Console.WriteLine("=======================\n CUSTOMER INFORMATION \n=======================");
            Console.WriteLine("NAME: {0}",jame.name);
            Console.WriteLine("E-MAIL: {0}",jame.email);
            orderTshirt.showinformation();
            Console.WriteLine();
          
           


        }
            }
        }
  
       
    