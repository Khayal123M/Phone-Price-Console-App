// See https://aka.ms/new-console-template for more information
using Phone_Price_Console_App;

namespace MainPage
{

    class Program
    {
        static void Main(string[] args)
        {

            Phone phone = new Phone();

            phone.Name = "Khayal";
            phone.Surname = "Mamedov";
            phone.Phone_Brand = "Samsung";
            phone.Phone_Price = 250;
            phone.Operating_System = "Android";
            phone.RAM_Size = 4;


            while (true)
            {
                Console.WriteLine("Choise");
                int Choise = Convert.ToInt32(Console.ReadLine());
                if (Choise == 1)
                {
                    phone.Personel_Info();
                }
                else if (Choise == 2)
                {
                    phone.Phone_Info();
                }
                else if (Choise == 3)
                {
                    Console.WriteLine("Please enter your balance");
                    phone.Balance = Convert.ToInt32(Console.ReadLine());
                    phone.Purchasability();
                }
                else
                {
                    Console.WriteLine("Invalid Choise");
                }


            }





        }

    }

}
