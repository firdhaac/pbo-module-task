using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }    
    }
    class Asus : Laptop
    {
        public Asus() 
        {
            base.merk = "ASUS";
        }
    }
    class Acer : Laptop
    {
        public Acer() 
        {
            base.merk = "ACER";
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo() 
        {
            base.merk = "LENOVO";
        }
    }
    class ROG : Asus
    {
        public ROG() 
        {
            base.tipe = "ROG";
        }
    }
    class Vivobook : Asus
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {

            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    class Swift : Acer
    {
        public Swift ()
        {
            base.tipe = "Swift";
        }
    }
    class Predator : Acer
    {
        public Predator ()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad() 
        {
            base.tipe = "IdeaPad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
