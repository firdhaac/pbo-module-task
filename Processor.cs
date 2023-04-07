using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Processor
    {
        public string merk, tipe; 
    }
    class Intel : Processor
    {
        public Intel() 
        {
            base.merk = "Intel";
        }
    }
    class Corei3 : Intel
    {
        public Corei3() 
        {
            base.tipe = "Core i3";
        }
    }
    class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Core i5";
        }
    }
    class Corei7 : Intel
    {
        public Corei7() 
        {
            base.tipe = "Core i7";
        }
    }
    class Amd : Processor
    {
        public Amd() 
        {
            base.merk = "AMD";
        }
    }
    class Ryzen : Amd
    {
        public Ryzen() 
        {
            base.tipe = "RYZEN";
        }
    }
    class Athlon : Amd
    {
        public Athlon() 
        {
            base.tipe = "ATHLON";
        } 
    }

