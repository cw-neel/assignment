using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList= new List<Car>();
            bool asking = true;
            int x,y;
            long searchPrice;
            string searchKey;
            while(asking){
                Console.WriteLine("\n1:Add Car\n2:Search\nAny Other Key To Exit");
                x = Int16.Parse(Console.ReadLine());
                switch(x){
                    case 1:
                        Console.WriteLine("\nEnter Name: ");
                        string tempName = Console.ReadLine();
                        Console.WriteLine("\nEnter Price: ");
                        long tempPrice = long.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter Location: ");
                        string tempLocation = Console.ReadLine();
                        carList.Add(new Car(tempName,tempPrice,tempLocation));
                        break;
                    case 2:
                        Console.WriteLine("\n1:Search By Name\n2:Search By Max Price\n3:Search By Location\nAny Other Key for all cars");
                        y = Int16.Parse(Console.ReadLine());
                        switch(y){
                            case 1:
                                Console.WriteLine("\nEnter Name: ");
                                searchKey = Console.ReadLine();
                                display(carList.FindAll(c=>c.name.ToUpper().Contains(searchKey.ToUpper())));
                                break;
                            case 2:
                                Console.WriteLine("\nEnter Max Price: ");
                                searchPrice = long.Parse(Console.ReadLine());
                                display(carList.FindAll(c=>c.price<=searchPrice));
                                break;
                            case 3:
                                Console.WriteLine("\nEnter Location: ");
                                searchKey = Console.ReadLine();
                                display(carList.FindAll(c=>c.location.ToUpper().Contains(searchKey.ToUpper())));
                                break;
                            default:
                                display(carList);
                                break;
                        }
                        break;
                    default:
                        asking = false;
                        break;
                }
            }
        }
        static void display(List<Car> carList){
            if(carList.Count==0)
                Console.WriteLine("\nNo Results Found");
            else{
                Console.WriteLine("\nNAME\t\tPRICE\t\tLOCATION");
                foreach(Car tempCar in carList)
                    tempCar.display();
            }
        }
    }
}
