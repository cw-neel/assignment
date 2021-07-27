using System;

namespace test
{
    class Car
    {
        public string name{get; set;}
        public long price{get; set;}
        public string location{get; set;}
        public Car(string name,long price,string location){
          this.name = name;
          this.price = price;
          this.location = location;
        }
        public void display(){
          Console.WriteLine($"{this.name}\t\t{this.price}\t\t{this.location}");
        }
    }
}
