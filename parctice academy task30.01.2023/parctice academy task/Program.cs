using System;

namespace parctice_academy_task
{
    internal class program
    {
        static void Main(string[] args)
        {
            #region Bicycle1
            //bicycle bcy1 = new bicycle
            //{
            //    brand = "moto",
            //    model = "pro021",
            //    millage = 20
            //};

            //bcy1.drive(10);
            //bcy1.drive(20);
            //console.writeline(bcy1.millage);
            #endregion

            #region Bicycle2
            //Console.WriteLine("Velosiped sayi:");
            //string countStr = Console.ReadLine();
            //int count = Convert.ToInt32(countStr);

            //Bicycle[] bicycles = new Bicycle[count];


            //for (int i = 0; i < bicycles.Length; i++)
            //{

            //    string brand;
            //    do
            //    {
            //        Console.WriteLine("Brand: ");
            //        brand = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(brand));

            //    string model;
            //    do
            //    {
            //        Console.WriteLine("Model: ");
            //        model = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(model));


            //    Bicycle bc = new Bicycle
            //    {
            //        Brand = brand,
            //        Model = model
            //    };

            //    bicycles[i] = bc;
            //}

            //Console.WriteLine("1. Butun velosipedlere bax");
            //Console.WriteLine("2. Velosipedler arasinda model adina gore axtaris et");

            //Console.WriteLine("Emeliyyat secin:");
            //string option = Console.ReadLine();

            //if (option == "1")
            //{
            //    foreach (var item in bicycles)
            //    {
            //        Console.WriteLine($"Brand: {item.Brand} - Model: {item.Model} - Millage: {item.Millage}");
            //    }
            //}
            //else if (option == "2")
            //{
            //    Console.WriteLine("Modeli daxil edin:");
            //    string wantedModel = Console.ReadLine();

            //    foreach (var item in bicycles)
            //    {
            //        if (item.Model==wantedModel)
            //            Console.WriteLine($"Brand: {item.Brand} - Model: {item.Model} - Millage: {item.Millage}");
            //    }
            //}
            #endregion

            #region  Product
            Product product = new Product("new product", 160);
            Phone phone = new Phone("Iphone 13", 1950) { Camera = 16 };
            Notebook notebook = new Notebook("Asus", 199) { Storage = 512, RAM = 16 };

            notebook.ShowInfo();

            Phone[] phones = new Phone[0];


            string newoption;
            do
            {
                Console.WriteLine("1. Telefonlara bax");
                Console.WriteLine("2. Adina gore axtaris et");
                Console.WriteLine("3. Telefon elave et");
                Console.WriteLine("0. Cix");

                newoption = Console.ReadLine();

                switch (newoption)
                {
                    case "1":
                        Console.WriteLine("Butun telefonlari gostereceksiniz");
                        break;
                    case "2":
                        Console.WriteLine("Telefonlar icerisinde axtaris et");
                        break;
                    case "3":
                        Console.WriteLine("Telefon datalarini consoledan gorutub, yeni telefon yaradib, arraye elave etmek");
                        break;
                    case "0":
                        newoption = "-1";
                        Console.WriteLine("Eminsinizmi? y/n");
                        if (Console.ReadLine() == "y")
                        {
                            newoption = "0";
                        }
                        break;
                    default:
                        Console.WriteLine("Yanlis secim etdiniz, yeniden secin!");
                        break;
                }
            } while (newoption != "0");
            #endregion

        }
    }
}
