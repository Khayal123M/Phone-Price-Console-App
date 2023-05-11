using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Price_Console_App
{
    public class Phone
    {
        // Parameters
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone_Brand { get; set; }
        public string Operating_System { get; set; }
        public int RAM_Size { get; set; }
        public int Phone_Price { get; set; }
        public int Balance { get; set; }

        // Methods

        public void Personel_Info()
        {

            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Surname = " + Surname);


        }

        public void Phone_Info()
        {
            Console.WriteLine("Operating System = " + Operating_System);
            Console.WriteLine("Phone Brand = " + Phone_Brand);
            Console.WriteLine("Ram Size = " + RAM_Size);
            Console.WriteLine("Phone Price = " + Phone_Price);

        }

        public void Purchasability()
        {
            if(Balance >= Phone_Price)
            {
                Console.WriteLine("You have sufficient balance. You can purchase the phone.");
            }
            else
            {
                Console.WriteLine("You don't have enough balance to purchase this phone.");
            }
        }


    }


    




}
